//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmCodes;

    [ApiHost]
    public readonly partial struct AsmRegs
    {
        [Op]
        public static AsmRegQuery query()
            => new AsmRegQuery(list(GP));

        [MethodImpl(Inline), Op]
        public static bool valid(RegIndexCode src)
            => (uint)src <= 31;

        [MethodImpl(Inline), Op]
        public static bool invalid(RegIndexCode src)
            => (uint)src >= 32;
    }
}