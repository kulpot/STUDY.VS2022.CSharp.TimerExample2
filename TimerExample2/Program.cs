




using System.Timers;



namespace TimerExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Timer myTimer = new Timer(2000);
            System.Timers.Timer myTimer = new System.Timers.Timer(2000);

            myTimer.Elapsed += MyTimer_Elapsed;

            myTimer.Start();

            Console.ReadLine();

        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }

    }
}
/*
using System;
using System.Threading;

namespace TimerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(MyTimerCallback, null, 2000, 2000);

            Console.ReadLine();

            myTimer.Dispose();
        }

        private static void MyTimerCallback(Object o)
        {
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", DateTime.Now);
        }
    }
}*/
/*
using System;
using System.Threading.Tasks;

namespace TimerExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", DateTime.Now);
                await Task.Delay(2000);
            }
        }
    }
}*/
/*
using System;
using System.Threading;
using System.Threading.Tasks;

namespace TimerExample2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var cts = new CancellationTokenSource();
            var token = cts.Token;

            Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", DateTime.Now);
                    Task.Delay(2000, token).Wait();
                }
            }, token);

            Console.WriteLine("Press enter to stop the timer...");
            Console.ReadLine();
            cts.Cancel();
        }
    }
}*/
