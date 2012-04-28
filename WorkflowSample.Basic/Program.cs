using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace WorkflowSample.Basic
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("◆実行したいワークフローを選択してください。");
            Console.WriteLine("　1: Sequenceのサンプル");
            Console.WriteLine("　2: Flowchartのサンプル");
            Console.WriteLine("　3: StateMachineのサンプル");
            Console.Write("何番を実行しますか？：");
            var num = Console.ReadLine();
            Console.WriteLine("");

            Activity act;


            if (num == "1")
            {
                act = new Sequence();
            }
            else if (num == "2")
            {
                act = new Flowchart();
            }
            else if (num == "3")
            {
                act = new StateMachine();
            }
            else
            {
                throw new NotSupportedException();
            }

            //ワークフローの実行
            WorkflowInvoker.Invoke(act);
        }
    }
}
