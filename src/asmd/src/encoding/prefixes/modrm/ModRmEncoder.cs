//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;
    using static Typed;

    [ApiHost("encoding.modrm")]
    public readonly struct ModRmEncoder
    {
        public static ModRmEncoder Service => default;

        internal const byte RmIndex = 0;

        internal const byte RegIndex = 2;

        internal const byte ModIndex = 6;

        internal const byte RmMask = 0b00000111;

        internal const byte RegMask = 0b00111000;

        internal const byte ModMask = 0b11000000;

        [MethodImpl(Inline), Op]
        public static ModRm define(byte src)
            => new ModRm(src);        

        [MethodImpl(Inline), Op]
        public static ModRm define(uint3 rm, uint3 reg, uint2 mod)
            => new ModRm(rm,reg,mod);

        [MethodImpl(Inline), Op]
        public static int fill(Span<ModRmEncoding> dst)
        {
            var rm = SmallInts.data(w3);
            var reg = SmallInts.data(w3);
            var mod = SmallInts.data(w2);
            var i = 0;
            for(var a=0; a<rm.Length; a++)
            for(var b=0; b<reg.Length; b++)
            for(var c=0; c<mod.Length; c++, i++)
            {
                var _rm = skip(rm, a);
                var _reg = skip(reg, b);
                var _mod = skip(mod, c);
                var _enc = define(_rm, _reg, _mod);
                seek(dst,i) = new ModRmEncoding(_rm, _reg, _mod, _enc);
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