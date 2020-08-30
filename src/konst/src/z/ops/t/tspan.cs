//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Covers an array with a <see cref='TableSpan{T}'/>
        /// </summary>
        /// <param name="src">The array to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static TableSpan<T> tspan<T>(T[] src)
            where T : struct
                => src;

        /// <summary>
        /// Creates a <see cref='TableSpan{T}'/> from a <see cref='List{T}'/>
        /// </summary>
        /// <param name="src">The array to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static TableSpan<T> tspan<T>(List<T> src)
            where T : struct
                => src.Array();

        /// <summary>
        /// Creates a <see cref='TableSpan{T}'/> from a <see cref='IEnumerable{T}'/>
        /// </summary>
        /// <param name="src">The array to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static TableSpan<T> tspan<T>(IEnumerable<T> src)
            where T : struct
                => src.Array();

        /// <summary>
        /// Allocates a <see cref='TableSpan{T}'/> for a specified number of cells
        /// </summary>
        /// <param name="count">The cell count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static TableSpan<T> tspan<T>(byte count)
            where T : struct
                => sys.alloc<T>(count);

        /// <summary>
        /// Allocates a <see cref='TableSpan{T}'/> for a specified number of cells
        /// </summary>
        /// <param name="count">The cell count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static TableSpan<T> tspan<T>(ushort count)
            where T : struct
                => sys.alloc<T>(count);

        /// <summary>
        /// Allocates a <see cref='TableSpan{T}'/> for a specified number of cells
        /// </summary>
        /// <param name="count">The cell count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static TableSpan<T> tspan<T>(uint count)
            where T : struct
                => sys.alloc<T>(count);

        /// <summary>
        /// Allocates a <see cref='TableSpan{T}'/> for a specified number of cells
        /// </summary>
        /// <param name="count">The cell count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static TableSpan<T> tspan<T>(ulong count)
            where T : struct
                => sys.alloc<T>(count);

        /// <summary>
        /// Allocates a <see cref='TableSpan{T}'/> for a specified number of cells
        /// </summary>
        /// <param name="count">The cell count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static TableSpan<T> tspan<T>(Count32 count)
            where T : struct
                => sys.alloc<T>(count);
    }
}