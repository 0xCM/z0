//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    using static Root;
    using static core;

    public sealed class Controller : AppService<Controller>
    {

        public void Control(ReadOnlySpan<string> args)
        {

            var context = ModelContext.create(Wf);
            RunSorters();
        }

        // void DefineGrammar()
        // {
        //     var g = Grammars.grammar("common");
        //     var p0 = g.Add(Grammars.production("binary_digit", '0', '1'));
        //     var p1 = g.Add(Grammars.production("decimal_digit", '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'));
        //     var p2 = g.Add(Grammars.production("hex_digit", '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'A', 'B', 'C', 'D', 'E', 'F'));
        //     var lower = Grammars.production("lowercase_letter", Rules.range('a','z'));
        //     g.Add(lower);
        //     var upper = Grammars.production("uppercase_letter", Rules.range('A','Z'));
        //     g.Add(upper);
        //     g.Add(Grammars.production("letter", lower, upper));
        //     Write(g.Format());
        // }

        void RunSorters()
        {
            var sorter = Networks.sorting<byte>();
            byte x0 = 9, x1 = 5, x2 = 2, x3 = 6;
            sorter.Send(x0,x1,x2,x3, out var y0, out var y1, out var y2, out var y3);
            Write(string.Format("{0} -> {1}", x0, y0));
            Write(string.Format("{0} -> {1}", x1, y1));
            Write(string.Format("{0} -> {1}", x2, y2));
            Write(string.Format("{0} -> {1}", x3, y3));
        }
    }

}