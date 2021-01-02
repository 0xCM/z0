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

    public readonly struct ModRmMasks
    {
        public const byte RmIndex = 0;

        public const byte RegIndex = 2;

        public const byte ModIndex = 6;

        public const byte RmMask = 0b00000111;

        public const byte RegMask = 0b00111000;

        public const byte ModMask = 0b11000000;

    }

    [ApiHost]
    public readonly struct ModRmEncoder
    {
        [MethodImpl(Inline), Op]
        public static ModRm define(byte src)
            => new ModRm(src);

        [MethodImpl(Inline), Op]
        public static ModRm define(uint3 rm, uint3 reg, uint2 mod)
            => new ModRm(rm,reg,mod);

        [MethodImpl(Inline), Op]
        public static uint fill(Span<ModRmEncoding> dst)
        {
            var rmF = BitSeqLiterals.bits(w3);
            var regF = BitSeqLiterals.bits(w3);
            var modF = BitSeqLiterals.bits(w2);

            var i = 0u;
            for(var a=0u; a<rmF.Length; a++)
            for(var b=0u; b<regF.Length; b++)
            for(var c=0u; c<modF.Length; c++, i++)
            {
                ref readonly var rm = ref skip(rmF, a);
                ref readonly var reg = ref skip(regF, b);
                ref readonly var mod = ref skip(modF, c);
                var encoded = define(rm, reg, mod);
                z.seek(dst, i) = new ModRmEncoding(rm, reg, mod, encoded);
            }
            return i;
        }

        public static ModRmEncoding[] Table()
        {
            var dst = sys.alloc<ModRmEncoding>(256);
            fill(dst);
            return dst;
        }
    }
}