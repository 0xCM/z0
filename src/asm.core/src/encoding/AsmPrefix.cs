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
    public readonly struct AsmPrefix
    {
        [MethodImpl(Inline), Op]
        public static ModRm modrm(byte src)
            => new ModRm(src);

        [MethodImpl(Inline), Op]
        public static MandatoryPrefix mandatory(MandatoryPrefixCode code)
            => new MandatoryPrefix(code);

        [MethodImpl(Inline), Op]
        public static ModRm modrm(uint3 rm, uint3 reg, uint2 mod)
            => new ModRm(Bits.join((rm, 0), (reg, 3), (mod, 6)));

        [MethodImpl(Inline), Op]
        public static ModRm modrm(uint3 r1, uint3 r2)
            => modrm(r1, r2, uint2.Max);

        [MethodImpl(Inline), Op]
        public static Vsib vsib(byte src)
            => new Vsib(src);

        [MethodImpl(Inline), Op]
        public static AsmSizeOverrides sizes(bit opsz, bit adsz)
            => new AsmSizeOverrides(opsz,adsz);

        [MethodImpl(Inline), Op]
        public static RexPrefix rex(uint4 wrxb)
            => math.or((byte)RexPrefixCode.Base, (byte)wrxb);

        [MethodImpl(Inline), Op]
        public static RexPrefix rex()
            => (byte)RexPrefixCode.Base;

        [MethodImpl(Inline), Op]
        public static RexPrefix rex(bit w, bit r, bit x, bit b)
        {
            var bx = math.slor((byte)b, 0, (byte)x, 1);
            var rw = math.slor((byte)r, 2, (byte)w, 3);
            return math.or(bx, rw, rex());
        }

        [MethodImpl(Inline), Op]
        public static BndPrefix bnd()
            => BndPrefixCode.BND;

        [MethodImpl(Inline), Op]
        public static BranchHint hint(bit bt)
            => bt ? BranchHintCode.BT : BranchHintCode.BNT;
    }
}