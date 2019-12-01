//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;
    using static DataBlocks;

    public static partial class BlockExtend    
    {
        [MethodImpl(Inline)]
        public static ref T BlockRef<T>(in Block32<T> src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref src.Head, index*src.BlockLength); 
        
        [MethodImpl(Inline)]
        public static ref T BlockRef<T>(in Block64<T> src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref src.Head, index*src.BlockLength); 

        [MethodImpl(Inline)]
        public static ref readonly T BlockRef<T>(in ConstBlock32<T> src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.AsRef(in src.Head), index*src.BlockLength);  

        [MethodImpl(Inline)]
        public static ref readonly T BlockRef<T>(in ConstBlock64<T> src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.AsRef(in src.Head), index*src.BlockLength);  

        [MethodImpl(Inline)]
        public static ref readonly T BlockRef<T>(in ConstBlock128<T> src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.AsRef(in src.Head), index*src.BlockLength);  

        [MethodImpl(Inline)]
        public static ref readonly T BlockRef<T>(in ConstBlock256<T> src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.AsRef(in src.Head), index*src.BlockLength);  

        /// <summary>
        /// Constructs a 128-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> ToBlock32<T>(this Span<T> src, N32 n = default)
             where T : unmanaged
                => DataBlocks.safeload(n,src);

        /// <summary>
        /// Constructs a 128-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> ToBlock64<T>(this Span<T> src, N64 n = default)
             where T : unmanaged
                => DataBlocks.safeload(n,src);

        /// <summary>
        /// Constructs a 128-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> ToBlock128<T>(this Span<T> src, N128 n = default)
             where T : unmanaged
                => DataBlocks.safeload(n,src);

        /// <summary>
        /// Constructs a 128-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> ToBlock256<T>(this Span<T> src, N256 n = default)
             where T : unmanaged
                => DataBlocks.safeload(n,src);

        static N32 n32 => default;

        static N64 n64 => default;

        static N128 n128 => default;

        static N256 n256 => default;


    }
}
