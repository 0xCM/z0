//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;    
    using System.Diagnostics;
    
    using static zfunc;
    
    public static class OsX
    {
        /// <summary>
        /// Retrieves information about a processes' threads
        /// </summary>
        /// <param name="proc">The process to query</param>
        public static IEnumerable<ProcessThread> ProcessThreads(this Process proc)
            => from ProcessThread pt in proc.Threads select pt;

        /// <summary>
        /// Covers an execution buffer with a span
        /// </summary>
        [MethodImpl(Inline)]
        public static unsafe Span<T> GetContent<T>(this ExecBufferToken src)
            where T : unmanaged
                => span((byte*)src.Handle.ToPointer(), src.Length).As<T>();

        /// <summary>
        /// Fills an execution buffer with span content
        /// </summary>
        /// <param name="src">The source content</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static unsafe void Fill<T>(this ExecBufferToken dst, ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var srcBytes = src.AsBytes();
            var dstBytes = dst.GetContent<byte>();
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
        /// Fills the buffer with supplied content
        /// </summary>
        /// <param name="content">The source content</param>
        /// <typeparam name="T">The content cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this ExecBufferToken dst, Span<T> content)
            where T : unmanaged        
                => dst.Fill(content.ReadOnly());

        /// <summary>
        /// Fills the buffer with supplied content
        /// </summary>
        /// <param name="content">The source content</param>
        /// <typeparam name="T">The content cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<T>(this ExecBufferToken dst, T[] content)   
            where T : unmanaged
                => dst.Fill(content.AsSpan().ReadOnly());

        /// <summary>
        /// Zero-fills an execution buffer
        /// </summary>
        [MethodImpl(Inline)]
        public static void Clear(this ExecBufferToken src)
            => src.GetContent<byte>().Clear();


    }
}