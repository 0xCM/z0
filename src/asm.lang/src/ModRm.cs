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

    public sealed class ModRm : WfService<ModRm>
    {
        Index<ModRmBits> _Table;

        public ModRm()
        {
            var dst = sys.alloc<ModRmBits>(256);
            fill(dst);
        }

        public ReadOnlySpan<ModRmBits> Table
        {
            get => _Table;
        }

        [MethodImpl(Inline), Op]
        public static ModRmBits define(byte src)
            => new ModRmBits(src);

        [MethodImpl(Inline), Op]
        public static ModRmBits define(uint3 rm, uint3 reg, uint2 mod)
            => new ModRmBits(rm, reg, mod);

        [Op]
        static uint fill(Span<ModRmBits> dst)
        {
            var rmF = BitSeq.bits(w3);
            var regF = BitSeq.bits(w3);
            var modF = BitSeq.bits(w2);

            var i = 0u;
            for(var a=0u; a<rmF.Length; a++)
            for(var b=0u; b<regF.Length; b++)
            for(var c=0u; c<modF.Length; c++, i++)
            {
                ref readonly var rm = ref skip(rmF, a);
                ref readonly var reg = ref skip(regF, b);
                ref readonly var mod = ref skip(modF, c);
                seek(dst, i) = define(rm, reg, mod);
            }
            return i;
        }

    }
}