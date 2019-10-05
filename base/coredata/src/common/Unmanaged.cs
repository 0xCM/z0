//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    /// <summary>
    /// Defines primary api surface for non-span unmanaged data manipulation 
    /// </summary>
    public static class Unmanaged
    {
        /// <summary>
        /// Presents a source reference as a byte reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref byte ByteRef<T>(ref T src)
            where T : unmanaged
                => ref Unsafe.As<T,byte>(ref src);

        /// <summary>
        /// Presents a source reference as a span of bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<byte> ByteSpan<T>(ref T src)
            where T : unmanaged
                => MemoryMarshal.CreateSpan(ref ByteRef(ref src), Unsafe.SizeOf<T>()); 

        /// <summary>
        /// Quries/manipulates an index-identified byte wihin an unmanaged data structure
        /// </summary>
        /// <param name="src">The source data structure</param>
        /// <param name="i">The 0-based and byte-relative index of the value to address</param>
        /// <typeparam name="T">The structure type</typeparam>
        [MethodImpl(Inline)]
        public static ref byte Part<T>(ref T src, int i)
            where T : unmanaged
            => ref Unsafe.Add(ref Unsafe.As<T, byte>(ref src), i);

        /// <summary>
        /// Quries/manipulates an index-identified value wihin an unmanaged data structure
        /// </summary>
        /// <param name="src">The source data structure</param>
        /// <param name="i">The 0-based and T-relative index of the value to address</param>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The type of value to manipulate</typeparam>
        [MethodImpl(Inline)]
        public static ref T Part<S,T>(ref S src, int index)
            where T : unmanaged
            where S : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<S, T>(ref src), index);
    }
}