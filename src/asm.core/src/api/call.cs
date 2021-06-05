//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmCallInfo call(AsmCallSite callsite, AsmCallee target)
            => new AsmCallInfo(callsite, target);

        [MethodImpl(Inline), Op]
        public static CallRel32 call(MemoryAddress client, uint dx)
            => new CallRel32(client, dx);
    }
}
