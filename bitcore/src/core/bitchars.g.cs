//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;

    partial class gbits
    {
        /// <summary>
        /// Constructs a sequence of n characters {ci} := [c_n-1,..., c_0]
        /// over the domain {'0','1'} according to whether the bit in the i'th 
        /// position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static void bitchars<T>(T src, Span<char> dst, int offset = 0)
            where T : unmanaged
                => BitStore.bitchars(src,dst,offset);

        /// <summary>
        /// Constructs a sequence of n characters {ci} := [c_n-1,..., c_0]
        /// over the domain {'0','1'} according to whether the bit in the i'th 
        /// position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static ReadOnlySpan<char> bitchars<T>(in T src)
            where T : unmanaged
        {
            var dst = new char[bitsize<T>()];
            bitchars(src, dst);
            return dst;
        }

        /// <summary>
        /// Converts a span of primal values to a span of characters, each of which represent a bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static Span<char> bitchars<T>(ReadOnlySpan<T> src, int? maxlen = null)
            where T : unmanaged
        {
            var seglen = bitsize<T>();
            var srclen = src.Length;
            Span<char> dst = new char[srclen * seglen];
            ref readonly var input = ref head(src);

            for(var i=0; i<srclen; i++)
                bitchars(skip(input,i)).CopyTo(dst, i*seglen);
            return maxlen != null && dst.Length >= maxlen ?  dst.Slice(0,maxlen.Value) :  dst;
        }
        
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static Span<char> bitchars<T>(Span<T> src, int? maxlen = null)
            where T : unmanaged
                => bitchars(src.ReadOnly(), maxlen);    
        
    }
}