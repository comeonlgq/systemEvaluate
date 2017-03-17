using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Threading;

namespace systemWindows
{
    public partial class costAnalysisForm : Form
    {
      //  int[] count = new int[5];//
        Boolean[] flag = new Boolean[5];
        Boolean manChooseclickFlag = false;
        public costAnalysisForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
     public struct RowScale
     {
         public int startRow;
         public int endRow;
     }
        private void ExampleExcelIntoForm_Load(object sender, EventArgs e)
        {
            
            string strConn;
            string fileName = "costAnalysis.xlsx";
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

            //// 设定包括Header和所有单元格的列宽自动调整

            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //// 设定包括Header和所有单元格的行高自动调整

            //dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //// 列头高度自动调整

            //dataGridView1.AutoResizeColumnHeadersHeight();
            //// 行头宽度自动调整

            //dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            //列宽度
            this.dataGridView1.Columns[0].Width = 100;
            this.dataGridView1.Columns[1].Width = 420;
            this.dataGridView1.Columns[2].Width = 300;
            this.dataGridView1.Columns[3].Width = 120;
            this.dataGridView1.Columns[4].Width = 120;
            this.dataGridView1.Columns[4].Name = "选择操作";


            //下面的代码是用来使dataGridView中的数据隔行显示不同颜色
            if (this.dataGridView1.Rows.Count != 0)
            {
                for (int i = 0; i < this.dataGridView1.Rows.Count; i = i +1)
                {
                    if ((i == 4) | (i == 9) | (i == 17) | (i == 13))
                        this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
                    this.dataGridView1.Rows[i].Cells[4].Value = false;
                   
                 }
            }

        }

        private void manChoose_Click(object sender, EventArgs e)
        {
            manChooseclickFlag = true;
            this.dataGridView1.Enabled = true;
        }

        private void clearOtherChoosed(DataGridView dataGridView0, int beginRow,int endRow,int row)
        {
            for (int i = beginRow; i <= endRow; i++)
            {
                if(i!=row)
                   dataGridView0.Rows[i].Cells[4].Value = false;
            }

        }


        private RowScale findWhereRowIs(DataGridView dataGridView0, int row)
        {
            RowScale rs = new RowScale();
            if (row >= 0 && row <4)
            {
                rs.startRow = 0;
                rs.endRow = 3;
            }
            else if (row <=8 )
            {
                rs.startRow = 4;
                rs.endRow = 8;
            }
            else if (row <=12 )
            {
                rs.startRow = 9;
                rs.endRow = 12;
            }
            else if (row <=16 )
            {
                rs.startRow = 13;
                rs.endRow = 16;
            }
            else if ( row <= 20)
            {
                rs.startRow = 17;
                rs.endRow = 20;
            }
           
            return rs;
        
        }
/*
        //该函数用于计算每个指标下有几个子选项
        private void countEveryStandOwnSonCount(System.Windows.Forms.DataGridView dataGridView0)
        {
            count[0]=4;
            count[1]=4;
            count[2]=3;
            count[3]=count[4]=3;
          //  int j = 1;//表示每个二级指标的编号
            
         //   while (j <= 5)
           // {
            //    for (int i = 0; i < dataGridView0.RowCount; i++)
            //    {
            //        if ((int)dataGridView0.Rows[i].Cells[0].Value == j)
            //        {
            //            count[j - 1] = count[j - 1] + 1;
            //        }
            //        else if ((int)dataGridView0.Rows[i].Cells[0].Value >j) 
            //       {
            //           break;
                    
            //        }
            //    }
            //    j++;
            //}
            //count[1] = count[0] + count[1];
            //count[2] = count[1] + count[2];
            //count[3] = count[2] + count[3];
            //count[4] = count[3] + count[4];
            //count[5] = count[4] + count[5];

        }
*/
        private void computerCount_Click(object sender, EventArgs e)
        {

        }

        private void totalCount_Click(object sender, EventArgs e)
        {

        }

        private void saveCostAnalysis_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(this.Width, this.Height);//实例化一个和窗体一样大的bitmap
            Graphics g = Graphics.FromImage(bit);
            g.CompositingQuality = CompositingQuality.HighQuality;//质量设为最高
            g.CopyFromScreen(this.Left, this.Top, 0, 0, new Size(this.Width, this.Height));//保存整个窗体为图片
            //g.CopyFromScreen(panel游戏区 .PointToScreen(Point.Empty), Point.Empty, panel游戏区.Size);//只保存某个控件（这里是panel游戏区）
            bit.Save("F:/评价方法/成本分析法.jpg");//默认保存格式为PNG，保存成jpg格式质量不是很好
        }

        private void findCostAnalysisSource_Click(object sender, EventArgs e)
        {
            //当用户点击了人工选择按钮时
            if (manChooseclickFlag)
            {
                MessageBox.Show("对不起，该操作无数据源！");
            }
            //当用户点击了智能计算按钮时，此时可以查看到数据源
            else { }
        }
        //返回按钮
        private void awayCostAnalysis_Click(object sender, EventArgs e)
        {
            AllMethodMessage amm = new AllMethodMessage();
            amm.Show();
            this.Close();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            RowScale rs = new RowScale();
         //   countEveryStandOwnSonCount(dataGridView1);
            rs=findWhereRowIs(dataGridView1, e.RowIndex);

            clearOtherChoosed(dataGridView1, rs.startRow, rs.endRow, e.RowIndex);
        }

        private void costAnalysisForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

     
    }
    }
