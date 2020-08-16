//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct AsmRunner
    {
        [MethodImpl(Inline), Op]
        public static AsmPipeRunner pipe(FilePath logpath)
            => new AsmPipeRunner(logpath);
    }
}