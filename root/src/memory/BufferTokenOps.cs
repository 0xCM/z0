//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Root;

    public static class BufferTokenOps
    {
        /// <summary>
        /// Covers a token-identified buffer with a span
        /// </summary>
        [MethodImpl(Inline)]
        public static unsafe Span<T> Content<T>(this BufferToken src)
            where T : unmanaged
                => SpanOps.span((byte*)src.Handle.ToPointer(), src.Length).As<T>();

        /// <summary>
        /// Fills a token-identified buffer with data from a span
        /// </summary>
        /// <param name="src">The source content</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static unsafe void Fill<T>(this BufferToken dst, ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var srcBytes = src.AsBytes();
            var dstBytes = dst.Content<byte>();
            if(srcBytes.Length <= dst.Length)
            {
                if(srcBytes.Length < dst.Length)
                    dstBytes.Clear();

                srcBytes.CopyTo(dstBytes);
            }
            else
                srcBytes.Slice(dst.Length).CopyTo(dstBytes);        
        }

        /// <summary>
        /// Fills a token-identified buffer with data from a span
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The source content</param>
        /// <typeparam name="T">The content cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this BufferToken dst, Span<T> src)
            where T : unmanaged        
                => dst.Fill(src.ReadOnly());

        /// <summary>
        /// Fills a token-identified buffer with data from an array
        /// </summary>
        /// <param name="src">The source content</param>
        /// <typeparam name="T">The content cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this BufferToken dst, T[] src)   
            where T : unmanaged
                => dst.Fill(src.AsSpan().ReadOnly());

        /// <summary>
        /// Zero-fills a token-identified buffer
        /// </summary>
        [MethodImpl(Inline)]
        public static void Clear(this BufferToken src)
            => src.Content<byte>().Clear();
    }
}