//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    ref struct Runner 
    {
        readonly IArtistryContext Context;   

        readonly Span<string> Buffer;     

        byte offset;

        [MethodImpl(Inline)]
        public Runner(IArtistryContext context)
        {
            Context = context;
            Buffer = z.span<string>(256);
            offset = 0;
        }

        public void Run()
        {
            CalcDemo.compute();
         
            // var pos = offset;
            // CalcDemo.run(Buffer, ref offset);
            // for(var i=pos; i<offset; i++)
            //     term.print(Buffer[i]);
        }
    }
}