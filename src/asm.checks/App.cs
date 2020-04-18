//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;
    using static Memories;

    class App : AsmShell<App>
    {        

        public override void RunShell(params string[] args)
        {
            var checks = AsmChecks.Create(Context);
            using var buffers = BufferSeq.alloc(Context.DefaultBufferLength, 3);
            checks.sub_megacheck(buffers);
        }

        public static void Main(params string[] args)
            => Launch(args);
    }
}