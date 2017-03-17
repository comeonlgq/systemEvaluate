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

namespace systemWindows
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Boolean manChooseclickFlag = false;
        Boolean[] isFlag = new Boolean[8];
        int[] count = new int[8];


        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“database2DataSet5.currencyStability”中。您可以根据需要移动或删除它。
            this.currencyStabilityTableAdapter.Fill(this.database2DataSet5.currencyStability);
            // TODO: 这行代码将数据加载到表“database2DataSet4.guansuiWant”中。您可以根据需要移动或删除它。
            this.guansuiWantTableAdapter.Fill(this.database2DataSet4.guansuiWant);
            // TODO: 这行代码将数据加载到表“database2DataSet3.foreignOwnership”中。您可以根据需要移动或删除它。
            this.foreignOwnershipTableAdapter.Fill(this.database2DataSet3.foreignOwnership);
            // TODO: 这行代码将数据加载到表“database2DataSet2.inflationExcel”中。您可以根据需要移动或删除它。
            this.inflationExcelTableAdapter.Fill(this.database2DataSet2.inflationExcel);
            // TODO: 这行代码将数据加载到表“database2DataSet1.ownershipAllowed”中。您可以根据需要移动或删除它。
            this.ownershipAllowedTableAdapter.Fill(this.database2DataSet1.ownershipAllowed);
            // TODO: 这行代码将数据加载到表“database2DataSet.localSourceAbility”中。您可以根据需要移动或删除它。
            this.localSourceAbilityTableAdapter.Fill(this.database2DataSet.localSourceAbility);
            // TODO: 这行代码将数据加载到表“databasePolicyStab.politicalStab”中。您可以根据需要移动或删除它。
            this.politicalStabTableAdapter.Fill(this.databasePolicyStab.politicalStab);
            // TODO: 这行代码将数据加载到表“dataSetMoneyBack.moneyBack”中。您可以根据需要移动或删除它。
            this.moneyBackTableAdapter.Fill(this.dataSetMoneyBack.moneyBack);
         

        }

        private void manChoose_Click(object sender, EventArgs e)
        {
            manChooseclickFlag = true;
            this.dataGridView1.Enabled = true;
            this.dataGridView2.Enabled = true;
            this.dataGridView3.Enabled = true;
            this.dataGridView4.Enabled = true;
            this.dataGridView5.Enabled = true;
            this.dataGridView6.Enabled = true;
            this.dataGridView7.Enabled = true;
            this.dataGridView8.Enabled = true;
        }


        private Boolean checkAllReasonIsSelected()
        {
            Boolean flag = true;
            isFlag[0] = findAllReasonSelectedState(dataGridView1);
            isFlag[1] = findAllReasonSelectedState(dataGridView2);
            isFlag[2] = findAllReasonSelectedState(dataGridView3);
            isFlag[3] = findAllReasonSelectedState(dataGridView4);
            isFlag[4] = findAllReasonSelectedState(dataGridView5);
            isFlag[5] = findAllReasonSelectedState(dataGridView6);
            isFlag[6] = findAllReasonSelectedState(dataGridView7);
            isFlag[7] = findAllReasonSelectedState(dataGridView8);
            for (int i = 0; i < 8; i++)
            {
                if (isFlag[i] == false)
                {
                    flag = false;
                    MessageBox.Show("请选择完所有的指标，然后再点击总分计算！", "温馨提示");
                    break;
                }
            }
            return flag;
        }

        private void totalCount_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (!checkAllReasonIsSelected())
            {
                this.textBox1.Text = "";
            }
            else
            {

                for (int i = 0; i < 8; i++)
                {
                    sum = sum + count[i];
                }
                this.textBox1.Text = sum.ToString();
            }
        }

        private void saveGradeEvaluate_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(this.Width, this.Height);//实例化一个和窗体一样大的bitmap
            Graphics g = Graphics.FromImage(bit);
            g.CompositingQuality = CompositingQuality.HighQuality;//质量设为最高
            g.CopyFromScreen(this.Left, this.Top, 0, 0, new Size(this.Width, this.Height));//保存整个窗体为图片
            bit.Save("F:/评价方法/等级分析法.jpg");//默认保存格式为PNG，保存成jpg格式质量不是很好
            MessageBox.Show("恭喜您数据保存成功！","温馨提示");

        }

        private void findGradeEvaluateSource_Click(object sender, EventArgs e)
        {
            //当用户点击了人工选择按钮时
            if (manChooseclickFlag)
            {
                MessageBox.Show("对不起，该操作无数据源！","温馨提示");
            }
            //当用户点击了智能计算按钮时，此时可以查看到数据源
            else 
            {
                MessageBox.Show("数据源正在整理中，请稍后！");
            }
        }

        private void awayGradeEvaluate_Click(object sender, EventArgs e)
        {
            AllMethodMessage amm = new AllMethodMessage();
            amm.Show();
            this.Close();
        }

        private void clearOtherChoosed(DataGridView dataGridView0, int row)
        {
            for (int i = 0; i < dataGridView0.RowCount; i++)
            {
                if (i != row)
                {
                    dataGridView0.Rows[i].Cells[3].Value = false;
                }
            }
        }

        private Boolean findAllReasonSelectedState(DataGridView dataGridView0)
        {
            Boolean flag = false;
            for (int i = 0; i < dataGridView0.RowCount; i++)
            {
                if (dataGridView0.Rows[i].Cells[3].Selected)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            count[0] = (int)this.dataGridView1.Rows[e.RowIndex].Cells[2].Value;
            clearOtherChoosed(dataGridView1, e.RowIndex);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            count[1] = (int)this.dataGridView2.Rows[e.RowIndex].Cells[2].Value;
            clearOtherChoosed(dataGridView2, e.RowIndex);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            count[2] = (int)this.dataGridView3.Rows[e.RowIndex].Cells[2].Value;
            clearOtherChoosed(dataGridView3, e.RowIndex);
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            count[3] = (int)this.dataGridView4.Rows[e.RowIndex].Cells[2].Value;
            clearOtherChoosed(dataGridView4, e.RowIndex);
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            count[4] = (int)this.dataGridView5.Rows[e.RowIndex].Cells[2].Value;
            clearOtherChoosed(dataGridView5, e.RowIndex);
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            count[5] = (int)this.dataGridView6.Rows[e.RowIndex].Cells[2].Value;
            clearOtherChoosed(dataGridView6, e.RowIndex);
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            count[6] = (int)this.dataGridView7.Rows[e.RowIndex].Cells[2].Value;
            clearOtherChoosed(dataGridView7, e.RowIndex);
        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            count[7] = (int)this.dataGridView8.Rows[e.RowIndex].Cells[2].Value;
            clearOtherChoosed(dataGridView8, e.RowIndex);
        }

        private void computerCount_Click(object sender, EventArgs e)
        {

        }
    }
}
