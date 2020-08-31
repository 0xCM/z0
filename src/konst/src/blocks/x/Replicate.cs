//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Clones a 32-bit blocked container
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static SpanBlock8<T> Replicate<T>(this in SpanBlock8<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new SpanBlock8<T>(dst);
        }

        /// <summary>
        /// Clones a 32-bit blocked container
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static SpanBlock16<T> Replicate<T>(this in SpanBlock16<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new SpanBlock16<T>(dst);
        }

        /// <summary>
        /// Clones a 32-bit blocked container
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static SpanBlock32<T> Replicate<T>(this in SpanBlock32<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new SpanBlock32<T>(dst);
        }

        /// <summary>
        /// Clones a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static SpanBlock64<T> Replicate<T>(this in SpanBlock64<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new SpanBlock64<T>(dst);
        }

        /// <summary>
        /// Clones a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static SpanBlock128<T> Replicate<T>(this in SpanBlock128<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new SpanBlock128<T>(dst);
        }

        /// <summary>
        /// Clones a 256-bit data block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static SpanBlock256<T> Replicate<T>(this in SpanBlock256<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new SpanBlock256<T>(dst);
        }

        /// <summary>
        /// Clones a 512-bit data block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static SpanBlock512<T> Replicate<T>(this in SpanBlock512<T> src)
            where T : unmanaged
        {
            Span<T> dst = new T[src.CellCount];
            src.CopyTo(dst);
            return new SpanBlock512<T>(dst);
        }
    }
}