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
using System.IO;
using System.Data.OleDb;

namespace systemWindows
{
    public partial class SimilarMethodForm : Form
    {
        public SimilarMethodForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Boolean manChooseclickFlag = false;

        private void manChoose_Click(object sender, EventArgs e)
        {
            manChooseclickFlag = true;
            this.dataGridView1.Enabled = true;
        }

        private void computerCount_Click(object sender, EventArgs e)
        {

        }

        private void saveSimilarMethod_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(this.Width, this.Height);//实例化一个和窗体一样大的bitmap
            Graphics g = Graphics.FromImage(bit);
            g.CompositingQuality = CompositingQuality.HighQuality;//质量设为最高
            g.CopyFromScreen(this.Left, this.Top, 0, 0, new Size(this.Width, this.Height));//保存整个窗体为图片
            //g.CopyFromScreen(panel游戏区 .PointToScreen(Point.Empty), Point.Empty, panel游戏区.Size);//只保存某个控件（这里是panel游戏区）
            bit.Save("F:/评价方法/相似度法.jpg");//默认保存格式为PNG，保存成jpg格式质量不是很好
        }

        private void findSimilarMethodSource_Click(object sender, EventArgs e)
        {
            //当用户点击了人工选择按钮时
            if (manChooseclickFlag)
            {
                MessageBox.Show("对不起，该操作无数据源！");
            }
            //当用户点击了智能计算按钮时，此时可以查看到数据源
            else { }
        }

        private void awaySimilarMethod_Click(object sender, EventArgs e)
        {
            AllMethodMessage amm = new AllMethodMessage();
            amm.Show();
            this.Close();
        }

        private void SimilarMethodForm_Load(object sender, EventArgs e)
        {
            string strConn;
            string fileName = "similaryMethod.xlsx";
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
        }
    }
}
