//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Seed;        

    partial class Blocks
    {
        /// <summary>
        /// Converts a generic reference into a void pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The type of the referenced data</typeparam>
        [MethodImpl(Inline),Op, NumericClosures(NumericKind.All)]
        static unsafe void* pvoid<T>(ref T src)
            => Unsafe.AsPointer(ref src);

        /// <summary>
        /// Presents generic reference as a generic pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline),Op, NumericClosures(NumericKind.All)]
        static unsafe T* ptr<T>(ref T src)
            where T : unmanaged
                => (T*)pvoid(ref src);

        /// <summary>
        /// Returns a generic pointer to the leading cell of the first block of a 16-bit blocked container
        /// </summary>
        /// <param name="src">The source block</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline),Op, NumericClosures(NumericKind.Width8 | NumericKind.Width16)]
        public static unsafe T* ptr<T>(in Block16<T> src)
            where T : unmanaged
                => ptr(ref src.Head);

        /// <summary>
        /// Returns a generic pointer to the leading cell of the first block of a 32-bit blocked container
        /// </summary>
        /// <param name="src">The source block</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline),Op, NumericClosures(NumericKind.Width8 | NumericKind.Width16 | NumericKind.Width32)]
        public static unsafe T* ptr<T>(in Block32<T> src)
            where T : unmanaged
                => ptr(ref src.Head);

        /// <summary>
        /// Returns a generic pointer to the leading cell of the first block of a 64-bit blocked container
        /// </summary>
        /// <param name="src">The source block</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline),Op, NumericClosures(NumericKind.All)]
        public static unsafe T* ptr<T>(in Block64<T> src)
            where T : unmanaged
                => ptr(ref src.Head);

        /// <summary>
        /// Returns a generic pointer to the leading cell of the first block of a 128-bit blocked container
        /// </summary>
        /// <param name="src">The source block</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline),Op, NumericClosures(NumericKind.All)]
        public static unsafe T* ptr<T>(in Block128<T> src)
            where T : unmanaged
                => ptr(ref src.Head);

        /// <summary>
        /// Returns a generic pointer to the leading cell of the first block of a 256-bit blocked container
        /// </summary>
        /// <param name="src">The source block</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline),Op, NumericClosures(NumericKind.All)]
        public static unsafe T* ptr<T>(in Block256<T> src)
            where T : unmanaged
                => ptr(ref src.Head);

        /// <summary>
        /// Returns a generic pointer to the leading cell of an index-identified block of a 16-bit blocked container
        /// </summary>
        /// <param name="src">The source block</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline),Op, NumericClosures(NumericKind.Width8 | NumericKind.Width16)]
        public static unsafe T* ptr<T>(in Block16<T> src, int block)
            where T : unmanaged
                => ptr(ref src.BlockRef(block));

        /// <summary>
        /// Returns a generic pointer to the leading cell of an index-identified block of a 32-bit blocked container
        /// </summary>
        /// <param name="src">The source block</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline),Op, NumericClosures(NumericKind.Width8 | NumericKind.Width16 | NumericKind.Width32)]
        public static unsafe T* ptr<T>(in Block32<T> src, int block)
            where T : unmanaged
                => ptr(ref src.BlockRef(block));

        /// <summary>
        /// Returns a generic pointer to the leading cell of an index-identified block of a 64-bit blocked container
        /// </summary>
        /// <param name="src">The source block</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline),Op, NumericClosures(NumericKind.All)]
        public static unsafe T* ptr<T>(in Block64<T> src, int block)
            where T : unmanaged
                => ptr(ref src.BlockRef(block));

        /// <summary>
        /// Returns a generic pointer to the leading cell of an index-identified block of a 128-bit blocked container
        /// </summary>
        /// <param name="src">The source block</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline),Op, NumericClosures(NumericKind.All)]
        public static unsafe T* ptr<T>(in Block128<T> src, int block)
            where T : unmanaged
                => ptr(ref src.BlockRef(block));

        /// <summary>
        /// Returns a generic pointer to the leading cell of an index-identified block of a 256-bit blocked container
        /// </summary>
        /// <param name="src">The source block</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline),Op, NumericClosures(NumericKind.All)]
        public static unsafe T* ptr<T>(in Block256<T> src, int block)
            where T : unmanaged
                => ptr(ref src.BlockRef(block));
    }
}