//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Root;

    partial struct Encoding
    {            
        [MethodImpl(Inline), Op]
        public static ModRm modrm(byte src)
            => new ModRm(src);        

        [MethodImpl(Inline), Op]
        public static ModRm modrm(triad rm, triad reg, duet mod)
            => new ModRm(rm,reg,mod);

        [MethodImpl(Inline), Op]
        public static int modrm(Span<ModRmEncoding> dst)
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
                var _enc = modrm(_rm, _reg, _mod);
                seek(dst,i) = new ModRmEncoding(_rm, _reg, _mod, _enc);
            }
            return i;
        }

        public static ModRmEncoding[] modrmTable()
        {
            var dst = sys.alloc<ModRmEncoding>(1024);            
            modrm(dst);
            return dst;
        }    
    }
}