using System;
using System.Linq;
using System.Threading.Tasks;
namespace Async_Study
{
    class Program
    {
        //Paralell隐式创建任务
        static void Main(string[] args)
        {
            //Parallel.Invoke
            Action action1 = () => { Console.WriteLine(": >"); };
            Parallel.Invoke(() => { Console.WriteLine(": )"); },
                () => { Console.WriteLine(": ]"); },
                action1);
            //Parallel.For
            Action<int> action2 = (i) => { };
            Parallel.For(1, 10, action2);
            //Parallel.ForEach
            var enumer = Enumerable.Range(1, 10);
            Parallel.ForEach(enumer, (i) => { Console.WriteLine(i); });
            Console.ReadKey();
        }
    }
}
