//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class AsmEncoder
    {
        [MethodImpl(Inline), Op]
        public static ModRm modrm(byte src)
            => new ModRm(src);

        [MethodImpl(Inline), Op]
        public static ModRm modrm(uint3 rm, uint3 reg, uint2 mod)
            => modrm(BitFields.join((rm, 0), (reg, 3), (mod, 6)));

        [MethodImpl(Inline), Op]
        public static ModRm modrm(uint3 r1, uint3 r2)
            => modrm(r1, r2, uint2.Max);
    }
}