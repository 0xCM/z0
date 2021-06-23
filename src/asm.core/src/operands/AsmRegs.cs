//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmDsl;

    [ApiHost]
    public readonly partial struct AsmRegs
    {
        [Op]
        public static AsmRegQuery query()
            => new AsmRegQuery(list(GP));

        [MethodImpl(Inline), Op]
        public static bool valid(RegIndex src)
            => (uint)src <= 31;

        [MethodImpl(Inline), Op]
        public static bool invalid(RegIndex src)
            => (uint)src >= 32;
    }
}