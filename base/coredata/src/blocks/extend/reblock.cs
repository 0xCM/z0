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

    partial class BlockExtend    
    {
        /// <summary>
        /// Converts 64-bit blocks to 32-bit blocks without allocation
        /// </summary>
        /// <param name="src">The source blocks</param>
        /// <param name="n">The target block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> Reblock<T>(this in Block32<T> src, N16 n)
             where T : unmanaged
                => new Block16<T>(src.Data);

        /// <summary>
        /// Converts 64-bit blocks to 32-bit blocks without allocation
        /// </summary>
        /// <param name="src">The source blocks</param>
        /// <param name="n">The target block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> Reblock<T>(this in Block64<T> src, N32 n)
             where T : unmanaged
                => new Block32<T>(src.Data);

        /// <summary>
        /// Converts 128-bit blocks to 16-bit blocks without allocation
        /// </summary>
        /// <param name="src">The source blocks</param>
        /// <param name="n">The target block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> Reblock<T>(this in Block128<T> src, N16 n)
             where T : unmanaged
                => new Block16<T>(src.Data);

        /// <summary>
        /// Converts 128-bit blocks to 32-bit blocks without allocation
        /// </summary>
        /// <param name="src">The source blocks</param>
        /// <param name="n">The target block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> Reblock<T>(this in Block128<T> src, N32 n)
             where T : unmanaged
                => new Block32<T>(src.Data);

        /// <summary>
        /// Converts 128-bit blocks to 64-bit blocks without allocation
        /// </summary>
        /// <param name="src">The source blocks</param>
        /// <param name="n">The target block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> Reblock<T>(this in Block128<T> src, N64 n)
             where T : unmanaged
                => new Block64<T>(src.Data);

        /// <summary>
        /// Converts 256-bit blocks to 16-bit blocks without allocation
        /// </summary>
        /// <param name="src">The source blocks</param>
        /// <param name="n">The target block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> Reblock<T>(this in Block256<T> src, N16 n)
             where T : unmanaged
                => new Block16<T>(src.Data);

        /// <summary>
        /// Converts 256-bit blocks to 32-bit blocks without allocation
        /// </summary>
        /// <param name="src">The source blocks</param>
        /// <param name="n">The target block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> Reblock<T>(this in Block256<T> src, N32 n)
             where T : unmanaged
                => new Block32<T>(src.Data);

        /// <summary>
        /// Converts 256-bit blocks to 64-bit blocks without allocation
        /// </summary>
        /// <param name="src">The source blocks</param>
        /// <param name="n">The target block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> Reblock<T>(this in Block256<T> src, N64 n)
             where T : unmanaged
                => new Block64<T>(src.Data);

        /// <summary>
        /// Converts 256-bit blocks to 64-bit blocks without allocation
        /// </summary>
        /// <param name="src">The source blocks</param>
        /// <param name="n">The target block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> Reblock<T>(this in Block256<T> src, N128 n)
             where T : unmanaged
                => new Block128<T>(src.Data);

        /// <summary>
        /// Converts 32-bit blocks to 32-bit blocks without allocation
        /// </summary>
        /// <param name="src">The source blocks</param>
        /// <param name="n">The target block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock16<T> Reblock<T>(this in ConstBlock32<T> src, N16 n)
             where T : unmanaged
                => new ConstBlock16<T>(src.Data);

        /// <summary>
        /// Converts 64-bit blocks to 16-bit blocks without allocation
        /// </summary>
        /// <param name="src">The source blocks</param>
        /// <param name="n">The target block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock16<T> Reblock<T>(this in ConstBlock64<T> src, N16 n)
             where T : unmanaged
                => new ConstBlock16<T>(src.Data);

        /// <summary>
        /// Converts 64-bit blocks to 32-bit blocks without allocation
        /// </summary>
        /// <param name="src">The source blocks</param>
        /// <param name="n">The target block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock32<T> Reblock<T>(this in ConstBlock64<T> src, N32 n)
             where T : unmanaged
                => new ConstBlock32<T>(src.Data);

        /// <summary>
        /// Converts 128-bit blocks to 16-bit blocks without allocation
        /// </summary>
        /// <param name="src">The source blocks</param>
        /// <param name="n">The target block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock16<T> Reblock<T>(this in ConstBlock128<T> src, N16 n)
             where T : unmanaged
                => new ConstBlock16<T>(src.Data);

        /// <summary>
        /// Converts 128-bit blocks to 32-bit blocks without allocation
        /// </summary>
        /// <param name="src">The source blocks</param>
        /// <param name="n">The target block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock32<T> Reblock<T>(this in ConstBlock128<T> src, N32 n)
             where T : unmanaged
                => new ConstBlock32<T>(src.Data);

        /// <summary>
        /// Converts 128-bit blocks to 64-bit blocks without allocation
        /// </summary>
        /// <param name="src">The source blocks</param>
        /// <param name="n">The target block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock64<T> Reblock<T>(this in ConstBlock128<T> src, N64 n)
             where T : unmanaged
                => new ConstBlock64<T>(src.Data);

        /// <summary>
        /// Converts 256-bit blocks to 16-bit blocks without allocation
        /// </summary>
        /// <param name="src">The source blocks</param>
        /// <param name="n">The target block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock16<T> Reblock<T>(this in ConstBlock256<T> src, N16 n)
             where T : unmanaged
                => new ConstBlock16<T>(src.Data);

        /// <summary>
        /// Converts 256-bit blocks to 32-bit blocks without allocation
        /// </summary>
        /// <param name="src">The source blocks</param>
        /// <param name="n">The target block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock32<T> Reblock<T>(this in ConstBlock256<T> src, N32 n)
             where T : unmanaged
                => new ConstBlock32<T>(src.Data);

        /// <summary>
        /// Converts 256-bit blocks to 64-bit blocks without allocation
        /// </summary>
        /// <param name="src">The source blocks</param>
        /// <param name="n">The target block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock64<T> Reblock<T>(this in ConstBlock256<T> src, N64 n)
             where T : unmanaged
                => new ConstBlock64<T>(src.Data);

        /// <summary>
        /// Converts 256-bit blocks to 64-bit blocks without allocation
        /// </summary>
        /// <param name="src">The source blocks</param>
        /// <param name="n">The target block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock128<T> Reblock<T>(this in ConstBlock256<T> src, N128 n)
             where T : unmanaged
                => new ConstBlock128<T>(src.Data);
    }
}