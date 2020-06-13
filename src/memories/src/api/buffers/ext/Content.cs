//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Covers a token-identified buffer with a span
        /// </summary>
        [MethodImpl(Inline)]
        public static unsafe Span<T> Content<T>(this IBufferToken src)
            where T : unmanaged
                => Buffers.content<T>(src);

        /// <summary>
        /// Fills a token-identified buffer with data from a source span and returns the target memory to the caller as a span
        /// </summary>
        /// <param name="src">The source content</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static unsafe Span<T> Fill<T>(this IBufferToken dst, ReadOnlySpan<T> src)
            where T : unmanaged
                => Buffers.fill<T>(src, dst);
        // {
        //     var srcBytes = src.AsBytes();
        //     var dstBytes = dst.Content<byte>();
        //     if(srcBytes.Length <= dst.Size)
        //     {
        //         if(srcBytes.Length < dst.Size)
        //             dstBytes.Clear();

        //         srcBytes.CopyTo(dstBytes);
        //     }
        //     else
        //         srcBytes.Slice(dst.Size).CopyTo(dstBytes);  

        //     return dst.Content<T>();         
        // }

        /// <summary>
        /// Zero-fills a token-identified buffer
        /// </summary>
        [MethodImpl(Inline)]
        public static void Clear(this IBufferToken src)
            => Buffers.clear(src); //src.Content<byte>().Clear();
    }
}