//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        [MethodImpl(Inline)]
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
        [MethodImpl(Inline)]
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
        public static Span<char> bitchars<T>(ReadOnlySpan<T> src, int? maxlen = null)
            where T : unmanaged
        {
            var seglen = bitsize<T>();
            Span<char> dst = new char[src.Length * seglen];
            for(var i=0; i<src.Length; i++)
                bitchars(src[i]).CopyTo(dst, i*seglen);
            return maxlen != null && dst.Length >= maxlen ?  dst.Slice(0,maxlen.Value) :  dst;
        }
        
        [MethodImpl(Inline)]
        public static Span<char> bitchars<T>(Span<T> src, int? maxlen = null)
            where T : unmanaged
                => bitchars(src.ReadOnly(), maxlen);    
        
        public static ref T parse<T>(ReadOnlySpan<char> src, int offset, out T dst)
            where T : unmanaged
        {            
            var last = math.min(bitsize<T>(), src.Length) - 1;                                    
            dst = default;
            for(int i=offset, pos = 0; i<= last; i++, pos++)
                if(src[i] == bit.One)
                    dst = gbits.enable(dst, pos);                        
            return ref dst;
        }
    }
}