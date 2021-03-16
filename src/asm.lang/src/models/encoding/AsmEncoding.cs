//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct AsmEncoding
    {
        [MethodImpl(Inline), Op]
        public static ModRmBits modrm(byte src)
            => new ModRmBits(src);

        [MethodImpl(Inline), Op]
        public static ModRmBits modrm(uint3 rm, uint3 reg, uint2 mod)
            => new ModRmBits(rm, reg, mod);

        public static Index<ModRmBits> table(out Index<ModRmBits> dst)
        {
            dst = alloc<ModRmBits>(256);
            fill(dst);
            return dst;
        }

        [Op]
        public static uint fill(Span<ModRmBits> dst)
        {
            var i = 0u;
            var rmF = BitSeq.bits(n3);
            var regF = BitSeq.bits(n3);
            var modF = BitSeq.bits(n2);

            for(var a=0u; a<rmF.Length; a++)
            for(var b=0u; b<regF.Length; b++)
            for(var c=0u; c<modF.Length; c++, i++)
            {
                ref readonly var rm = ref skip(rmF, a);
                ref readonly var reg = ref skip(regF, b);
                ref readonly var mod = ref skip(modF, c);
                seek(dst, i) = modrm(rm, reg, mod);
            }
            return i;
        }
    }
}