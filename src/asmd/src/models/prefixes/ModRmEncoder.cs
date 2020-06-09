//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    [ApiHost]
    public readonly struct ModRmEncoder : IApiHost<ModRmEncoder>
    {
        public static ModRmEncoder Service => default(ModRmEncoder);

        [MethodImpl(Inline), Op]
        public ModRm encode(triad rm, triad reg, duet mod)
            => new ModRm(rm,reg,mod);

        [MethodImpl(Inline), Op]
        public int table(Span<ModRmEncoding> dst)
        {
            var encoder = PrefixEncoders.ModRm;
            var rm = BitSet.Triads;
            var reg = BitSet.Triads;
            var mod = BitSet.Duets;
            var i = 0;
            for(var a=0; a<rm.Length; a++)
            for(var b=0; b<reg.Length; b++)
            for(var c=0; c<mod.Length; c++, i++)
            {
                var _rm = skip(rm, a);
                var _reg = skip(reg, b);
                var _mod = skip(mod, c);
                var _enc = encode(_rm, _reg, _mod);
                seek(dst,i) = new ModRmEncoding(_rm, _reg, _mod, _enc);
            }
            return i;
        }

        internal const byte RmIndex = 0;

        internal const byte RegIndex = 2;

        internal const byte ModIndex = 6;

        internal const byte RmMask = 0b00000111;

        internal const byte RegMask = 0b00111000;

        internal const byte ModMask = 0b11000000;
    }
}