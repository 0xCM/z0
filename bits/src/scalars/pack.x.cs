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

        /// <summary>
        /// Converts a source value to a span of 8 bytes, 
        /// each of which represent a single int in the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<byte> Unpack(this byte src)
            => Bits.unpack(src);

        /// <summary>
        /// Converts a source value to a span of 16 bytes, 
        /// each of which represent a single int in the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<byte> Unpack(this ushort src)
            => Bits.unpack(src);

        /// <summary>
        /// Converts a source value to a span of 64 bytes, 
        /// each of which represent a single int in the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<byte> Unpack(this ulong src)
            => Bits.unpack(src);

        public static Span<byte> Unpack(this ReadOnlySpan<byte> src)
        {            
            var dst = span<byte>(src.Length*8);
            var offset = 0;
            for(var i = 0; i<src.Length; i++, offset += 8)
                src[i].Unpack().CopyTo(dst.Slice(offset));
            return dst;
        }

        [MethodImpl(Inline)]        
        public static Span<byte> Unpack(this Span<byte> src)
            => src.ReadOnly().Unpack();

        [MethodImpl(Inline)]        
        public static Span<byte> Unpack(this Span<ushort> src)
            => src.AsBytes().Unpack();

        [MethodImpl(Inline)]        
        public static Span<byte> Unpack(this Span<uint> src)
            => src.AsBytes().Unpack();

        [MethodImpl(Inline)]        
        public static Span<byte> Unpack(this Span<ulong> src)
            => src.AsBytes().Unpack();

    }

}