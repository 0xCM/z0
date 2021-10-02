//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Threading.Tasks;
    using static core;

    public sealed class Controller : AppService<Controller>
    {
        public void Control(ReadOnlySpan<string> args)
        {
            var counter = 0u;
            var ticks = 0L;
            void Receiver(long t)
            {
                counter++;
                ticks += t;
                Write(string.Format("{0:D4}:{1:D12}", counter, ticks));
            }

            var spinner = new Spinner(TimeSpan.FromSeconds(1),Receiver);
            spinner.Spin();
        }
    }

    public class Spinner
    {
        volatile bool Continue;

        readonly SpinWait Wait;

        long Cycles;

        Action<long> Receive;

        Duration Frequency;

        Timestamp Time;

        public Spinner(TimeSpan frequency, Action<long> receiver)
        {
            Continue = true;
            Cycles = 0;
            Cycles= new();
            Receive = receiver;
            Frequency = frequency;
            Time = Timestamp.Zero;
        }

        public void Stop()
        {
            Continue = false;
        }

        public void Spin()
        {
            Time = timestamp();
            while(Continue)
            {
                var now = timestamp();
                var prior = Time;
                Duration delta = now - prior;
                if(delta > Frequency)
                {
                    var cycles = Cycles;
                    run(() => Receive(cycles));
                    Time = timestamp();
                }

                Wait.SpinOnce();
                Cycles++;
            }
        }
    }
}