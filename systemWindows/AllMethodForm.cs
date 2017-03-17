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

namespace systemWindows
{
    public partial class AllMethodMessage : Form
    {
        public AllMethodMessage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Boolean evaluatFlag = false;//用来标记评价方法表是否有被选中
        Boolean forcastFlag = false;//用来标记预测方法表是否有被选中

        private void AllMethodMessage_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“database1DataSet.表3”中。您可以根据需要移动或删除它。
            this.表3TableAdapter.Fill(this.database1DataSet.表3);
            //下面的代码是用来使dataGridView中的数据隔行显示不同颜色
            if (this.dataGridView1.Rows.Count != 0)
            {
                for (int i = 0; i < this.dataGridView1.Rows.Count;i=i+2 )
                {
                    this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Pink;
                }
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!forcastFlag)
            {
                evaluatFlag = true;
                dataGridView1.Enabled = true;
                clearOtherChoosed(dataGridView1, e.RowIndex);
            }
            else
            {
                forcastFlag = true;
                dataGridView1.Enabled = false;
            }
           
        }


        private void focastMethodData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!evaluatFlag)
            {
                focastMethodData.Enabled = true;
                clearOtherChoosed(focastMethodData, e.RowIndex);
            }
            else
            {
                focastMethodData.Enabled = false;
            }
        }

  
        //这个方法是用来使其他行变得不可选
        private void clearOtherChoosed(System.Windows.Forms.DataGridView dataGridView0, int row)
        {
            for (int i = 0; i < dataGridView0.RowCount; i++)
            {
                if (i != row)
                {
                    dataGridView0.Rows[i].Cells[3].Value = false;
                }
            }
        }

        //该方法用于查找用户选中了哪一行数据
        private int findWhichRowIsSelected(DataGridView dataGridView0)
        {
            int row = -1;
            for (int i = 0; i < dataGridView0.RowCount; i++)
            {
                if ((Boolean)dataGridView0.Rows[i].Cells[3].Value)
                {
                    row = i;
                    break;
                }
            } 
            return row;
        }


        private void openEvaluateMethod(int row)
        {

            switch (row)
            {
                case 0:
                    costAnalysisForm caf = new costAnalysisForm();
                    caf.Show();
                    this.Hide();
                    break;
                case 1:
                    SampleEvaluateForm sef = new SampleEvaluateForm();
                    sef.Show();
                    this.Hide();
                    break;
                case 2:
                    SimilarMethodForm smf = new SimilarMethodForm();
                    smf.Show();
                    this.Hide();
                    break;
                case 3:
                    DynamicMethodForm dmf = new DynamicMethodForm();
                    dmf.Show();
                    this.Hide();
                    break;
                case 4:
                    MultiReasonResolveForm mrrf = new MultiReasonResolveForm();
                    mrrf.Show();
                    this.Hide();
                    break;
                case 5:
                    GreyCompareForm gcf = new GreyCompareForm();
                    gcf.Show();
                    this.Hide();
                    break;
                case 6:
                    ProfitReasonMethodForm prmf = new ProfitReasonMethodForm();
                    prmf.Show();
                    this.Hide();
                    break;
                case 7:
                    Form2 gef = new Form2();
                    gef.Show();
                    this.Hide();
                    break;
                case 8:
                    hotColdMethod hcm = new hotColdMethod();
                    hcm.Show();
                    this.Hide();
                    break;
                case 9:
                    MinMultiReaEvaluateForm mmrf = new MinMultiReaEvaluateForm();
                    mmrf.Show();
                    this.Hide();
                    break;
                case 10:
                    KeyReasonEvaluateForm kref = new KeyReasonEvaluateForm();
                    kref.Show();
                    this.Hide();
                    break;
                case 11:
                    InvestObstacleForm iof = new InvestObstacleForm();
                    iof.Show();
                    this.Hide();
                    break;
                case 12:
                    ReasonEvaluateForm ref1 = new ReasonEvaluateForm();
                    ref1.Show();
                    this.Hide();
                    break;
                default:
                    break;
            }

        }

        private void openForcastMethod(int row)
        { 
           
        
        }


        private void gotoNext_Click(object sender, EventArgs e)
        {
            int line = -1;
            //如果用户什么也没选，点击下一步，给出友情提示
            if (!evaluatFlag & !forcastFlag)
            { 
                MessageBox.Show("对不起，请您先选择一种方法，再进入下一步！");
            
            }
            else if (evaluatFlag)//表示用户选择的是评价方法
            {
                line = findWhichRowIsSelected(dataGridView1);
                openEvaluateMethod(line);
            }
            else if (forcastFlag)//表示用户选择的是预测方法
            {
                line = findWhichRowIsSelected(focastMethodData);
                openForcastMethod(line);
            }
        }

        private void turnBack_Click(object sender, EventArgs e)
        {
            denglu dl = new denglu();
            dl.Show();
            this.Close();
        }

        private void AllMethodMessage_FormClosed(object sender, FormClosingEventArgs e)
        {
           //关闭你要关闭的东西吧
            Application.Exit(); 
        }

    }
}
