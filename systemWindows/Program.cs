using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemWindows
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           Application.Run(new denglu());
        
          //  Application.Run(new costAnalysisForm());
       //     Application.Run(new GradeEvaluateMethodForm());
         //   Application.Run(new GreyCompareForm());
         //   Application.Run(new hotColdMethod());
         //  Application.Run(new InvestObstacleForm());

         //   Application.Run(new KeyReasonEvaluateForm());
          //  Application.Run(new MinMultiReaEvaluateForm());
        //    Application.Run(new MultiReasonResolveForm()); 
        //    Application.Run(new ProfitReasonMethodForm());
         //   Application.Run(new ReasonEvaluateForm());
           // Application.Run(new SampleEvaluateForm());
         //   Application.Run(new SimilarMethodForm());
          //  Application.Run(new Form2());
        }
    }
}
