using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Data.OleDb;

namespace systemWindows
{
    public partial class hotColdMethod : Form
    {
        public hotColdMethod()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        Boolean manChooseclickFlag = false;

        //用于查找dataGridView中哪一个选项被选中，为后续总分计算做准备
        public int findWhichChoosed(System.Windows.Forms.DataGridView dataGridView0)
        {
            int chooseScore = 0;
            for (int i = 0; i < dataGridView0.RowCount; i++)
            {
                if (dataGridView0.Rows[i].Cells[3].Selected)
                {
                    chooseScore = (int)dataGridView0.Rows[i].Cells[2].Value;
                    break;
                }
            }
            return chooseScore;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //  clearOtherChoosed(dataGridView1, e.RowIndex);
          
        }

        private void clearOtherChoosed(System.Windows.Forms.DataGridView dataGridView0, int row)
        {
            for (int i = 0; i < dataGridView0.RowCount; i++)
            {
                if (i!=row)
                {
                    dataGridView0.Rows[i].Cells[3].Value = false;
                }
            }
        }

/*
        private void ConvertJPG2PDF(string jpgfile, string pdf)
        {
            var document = new Document(iTextSharp.text.PageSize.A4, 25, 25, 25, 25);
            using (var stream = new FileStream(pdf, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter.GetInstance(document, stream);
                document.Open();
                using (var imageStream = new FileStream(jpgfile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    var image = iTextSharp.text.Image.GetInstance(imageStream);
                    if (image.Height > iTextSharp.text.PageSize.A4.Height - 25)
                    {
                        image.ScaleToFit(iTextSharp.text.PageSize.A4.Width - 25, iTextSharp.text.PageSize.A4.Height - 25);
                    }
                    else if (image.Width > iTextSharp.text.PageSize.A4.Width - 25)
                    {
                        image.ScaleToFit(iTextSharp.text.PageSize.A4.Width - 25, iTextSharp.text.PageSize.A4.Height - 25);
                    }
                    image.Alignment = iTextSharp.text.Image.ALIGN_MIDDLE;
                    document.Add(image);
                }

                document.Close();
            }
        
        }

        private void openPDF( string pdf)
        {
          
        }
*/


        //首先需要定义两个私有成员，一个委托。其中一个私有成员是保存当前进度条窗体对象，另一个是保存委托方法（即增加进度条尺度）
        private progressBarForm myProcessBar = null;
        private delegate bool IncreaseHandle(int nValue);
        private IncreaseHandle myIncrease = null;
        //进度条线程
        private void ThreadFun()
        {

            MethodInvoker mi = new MethodInvoker(ShowProcessBar);

            this.BeginInvoke(mi);

            Thread.Sleep(1000);//Sleep a while to show window

            bool blnIncreased = false;

            object objReturn = null;
            do
            {
                Thread.Sleep(50);

                objReturn = this.Invoke(this.myIncrease,

                    new object[] { 2 });

                blnIncreased = (bool)objReturn;

            }
            while (blnIncreased);
        }

        private void ShowProcessBar()
        {

            myProcessBar = new progressBarForm();
            // Init increase event
            myIncrease = new IncreaseHandle(myProcessBar.Increase);
            myProcessBar.ShowDialog();
            myProcessBar = null;

        }

        private void returnBack_Click(object sender, EventArgs e)
        {
            AllMethodMessage dl = new AllMethodMessage();
            dl.Show();
            this.Close();
        }

        private void saveHotCold_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(this.Width, this.Height);//实例化一个和窗体一样大的bitmap
            Graphics g = Graphics.FromImage(bit);
            g.CompositingQuality = CompositingQuality.HighQuality;//质量设为最高
            g.CopyFromScreen(this.Left, this.Top, 0, 0, new Size(this.Width, this.Height));//保存整个窗体为图片
            //g.CopyFromScreen(panel游戏区 .PointToScreen(Point.Empty), Point.Empty, panel游戏区.Size);//只保存某个控件（这里是panel游戏区）
            bit.Save("F:/评价方法/冷热图分析法.jpg");//默认保存格式为PNG，保存成jpg格式质量不是很好
            MessageBox.Show("保存成功！");
        }

        private void findHotColdSource_Click(object sender, EventArgs e)
        {
            //当用户点击了人工选择按钮时
            if (manChooseclickFlag)
            {
                MessageBox.Show("对不起，该操作无数据源！");
            }
            //当用户点击了智能计算按钮时，此时可以查看到数据源
            else { }
        }

        private void awayHotCold_Click(object sender, EventArgs e)
        {
            AllMethodMessage amm = new AllMethodMessage();
            amm.Show();
            this.Close();

        }

        private void manChoose_Click_1(object sender, EventArgs e)
        {
            manChooseclickFlag = true;
            this.dataGridView1.Enabled = true;
                
        }

        private void computerCount_Click_1(object sender, EventArgs e)
        {
            //弹出数据采集中，请等待的对话框
            //启动进度条线程
            Thread thdSub = new Thread(new ThreadStart(ThreadFun));
            thdSub.Start();
        }

        private void hotColdMethod_Load(object sender, EventArgs e)
        {
            string strConn;
            string fileName = "hotColdAnalysis.xlsx";
            strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=Excel 8.0"; ;
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string strExcel = "";
            OleDbDataAdapter myCommand = null;

            strExcel = "select  * from   [sheet1$]";
            myCommand = new OleDbDataAdapter(strExcel, conn);
            DataTable dt = new System.Data.DataTable();
            myCommand.Fill(dt);

            DataGridViewCheckBoxColumn c1 = new DataGridViewCheckBoxColumn();
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Columns.Add(c1);

            // 设定包括Header和所有单元格的列宽自动调整

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // 设定包括Header和所有单元格的行高自动调整

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // 列头高度自动调整

            dataGridView1.AutoResizeColumnHeadersHeight();
            // 行头宽度自动调整

            dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            for (int i = 0; i < 13; i=i+6)
            {
                for (int j = 3; j < 6;j++ )
                    this.dataGridView1.Rows[i+j].DefaultCellStyle.BackColor = Color.Pink;
            }

        }


    }
}
