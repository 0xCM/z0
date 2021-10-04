//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    public sealed class Controller : AppService<Controller>
    {

        void Spin()
        {
            var counter = 0u;
            var ticks = 0L;

            void Receiver(long t)
            {
                counter++;
                ticks += t;
                Write(string.Format("{0:D4}:{1:D12}", counter, ticks));
            }

            var spinner = new Spinner(TimeSpan.FromSeconds(1), Receiver);
            spinner.Spin();

        }

        public void Control(ReadOnlySpan<string> args)
        {

            DefineGrammar();


        }

        void DefineGrammar()
        {
            var g = Rules.grammar("common");
            var p0 = g.Add(Rules.production("binary_digit", '0', '1'));
            var p1 = g.Add(Rules.production("decimal_digit", '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'));
            var p2 = g.Add(Rules.production("hex_digit", '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'A', 'B', 'C', 'D', 'E', 'F'));
            var lower = Rules.production("lowercase_letter", Rules.range('a','z'));
            g.Add(lower);
            var upper = Rules.production("uppercase_letter", Rules.range('A','Z'));
            g.Add(upper);
            g.Add(Rules.production("letter", lower, upper));

            Write(g.Format());

        }
    }
}