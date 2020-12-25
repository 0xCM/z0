//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Part;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmPipe pipe(Func<AsmFxList,AsmFxList> f)
            => new AsmPipe(f);
    }
}