//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    partial class BitsX
    {       
        static Span<byte> unpack8x1(ReadOnlySpan<byte> src, Span<byte> dst)
        {            
            var offset = 0;
            for(var i = 0; i<src.Length; i++, offset += 8)
                BitStore.select(src[i]).CopyTo(dst.Slice(offset));
            return dst;
        }

        [MethodImpl(Inline)]        
        public static Span<byte> Unpack(this Span<byte> src)
            => unpack8x1(src, new byte[src.Length*8]);

        [MethodImpl(Inline)]        
        public static void Unpack(this Span<byte> src, Span<byte> dst)
            => unpack8x1(src, dst);

        [MethodImpl(Inline)]        
        public static void Unpack(this ReadOnlySpan<byte> src, Span<byte> dst)
            => unpack8x1(src, dst);

    }

}