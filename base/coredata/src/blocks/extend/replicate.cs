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

    partial class BlockExtend    
    {
        /// <summary>
        /// Clones a 32-bit blocked container
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> Replicate<T>(this in Block16<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new Block16<T>(dst);
        }

        /// <summary>
        /// Clones a 32-bit blocked container
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> Replicate<T>(this in Block32<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new Block32<T>(dst);
        }

        /// <summary>
        /// Clones a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> Replicate<T>(this in Block64<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new Block64<T>(dst);
        }

        /// <summary>
        /// Clones a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> Replicate<T>(this in Block128<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new Block128<T>(dst);
        }

        /// <summary>
        /// Clones a 256-bit data block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Replicate<T>(this in Block256<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new Block256<T>(dst);
        }

        /// <summary>
        /// Clones a 512-bit data block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block512<T> Replicate<T>(this in Block512<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new Block512<T>(dst);
        }

        /// <summary>
        /// Clones a 16-bit data block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> Replicate<T>(this in ConstBlock16<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new Block16<T>(dst);
        }

        /// <summary>
        /// Clones a 32-bit data block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> Replicate<T>(this in ConstBlock32<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new Block32<T>(dst);
        }

        /// <summary>
        /// Clones a 64-bit data block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> Replicate<T>(this in ConstBlock64<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new Block64<T>(dst);
        }

        /// <summary>
        /// Clones a 128-bit data block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> Replicate<T>(this in ConstBlock128<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new Block128<T>(dst);
        }

        /// <summary>
        /// Clones a 256-bit data block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Replicate<T>(this in ConstBlock256<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new Block256<T>(dst);
        }

        /// <summary>
        /// Clones a 256-bit data block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block512<T> Replicate<T>(this in ConstBlock512<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new Block512<T>(dst);
        }


    }
}