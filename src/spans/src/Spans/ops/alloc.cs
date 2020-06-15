//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Spans
    {
        /// <summary>
        /// Allocates a span
        /// </summary>
        /// <param name="length">The number cells to allocate</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Closures(UnsignedInts), Op]
        public static Span<T> alloc<T>(int length)
            => new Span<T>(new T[length]);

        /// <summary>
        /// Allocates a span
        /// </summary>
        /// <param name="length">The number cells to allocate</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Closures(UnsignedInts), Op]
        public static Span<T> alloc<T>(ushort length)
            => new Span<T>(new T[length]);

        /// <summary>
        /// Allocates a span
        /// </summary>
        /// <param name="length">The number cells to allocate</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Closures(UnsignedInts), Op]
        public static Span<T> alloc<T>(byte length)
            => new Span<T>(new T[length]);
    }
}