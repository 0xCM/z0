//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using Z0.Asm;

    using static Konst;
    using static z;

    ref struct Runner 
    {

        readonly WfState Wf;   

        readonly Span<string> Buffer;     

        byte offset;

        [MethodImpl(Inline)]
        public Runner(WfState wf)
        {
            Wf = wf;
            Buffer = z.span<string>(256);
            offset = 0;
        }

        void RunCalc()
        {
            CalcDemo.compute();
         
            var pos = offset;
            CalcDemo.run(Buffer, ref offset);
            for(var i=pos; i<offset; i++)
                term.print(Buffer[i]);
        }
        

        public void Dispose()
        {

        }

        public void Run()
        {
            using var step = new ListFormatPatterns(Wf, typeof(FormatAtoms));
            step.Run();
        }
    }
}