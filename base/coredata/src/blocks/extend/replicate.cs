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

    partial class BlockExtend    
    {
        /// <summary>
        /// Clones a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> Replicate<T>(this Block32<T> src)
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
        public static Block64<T> Replicate<T>(this Block64<T> src)
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
        public static Block128<T> Replicate<T>(this Block128<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new Block128<T>(dst);
        }

        /// <summary>
        /// Clones a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Replicate<T>(this Block256<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new Block256<T>(dst);
        }

        /// <summary>
        /// Clones a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> Replicate<T>(this ConstBlock32<T> src)
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
        public static Block64<T> Replicate<T>(this ConstBlock64<T> src)
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
        public static Block128<T> Replicate<T>(this ConstBlock128<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new Block128<T>(dst);
        }

        /// <summary>
        /// Clones a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Replicate<T>(this ConstBlock256<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new Block256<T>(dst);
        }
    }
}