//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial class Cells
    {
        /// <summary>
        /// Loads a width-selected cell from a specified source beginning at a specified byte-relative offset
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        [MethodImpl(Inline), Op]
        public static ref readonly Cell8 load(W8 w, ReadOnlySpan<byte> src, uint offset = 0)
            => ref core.first(recover<Cell8>(slice(src, offset)));

        /// <summary>
        /// Loads a width-selected cell from a specified source beginning at a specified byte-relative offset
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        [MethodImpl(Inline), Op]
        public static ref readonly Cell16 load(W16 w, ReadOnlySpan<byte> src, uint offset = 0)
            => ref core.first(recover<Cell16>(slice(src, offset)));

        /// <summary>
        /// Loads a width-selected cell from a specified source beginning at a specified source-relative offset
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        [MethodImpl(Inline), Op]
        public static ref readonly Cell32 load(W32 w, ReadOnlySpan<byte> src, uint offset = 0)
            => ref core.first(recover<Cell32>(slice(src, offset)));

        /// <summary>
        /// Loads a width-selected cell from a specified source beginning at a specified source-relative offset
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        [MethodImpl(Inline), Op]
        public static ref readonly Cell64 load(W64 w, ReadOnlySpan<byte> src, uint offset = 0)
            => ref core.first(recover<Cell64>(slice(src, offset)));

        /// <summary>
        /// Loads a width-selected cell from a specified source beginning at a specified source-relative offset
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        [MethodImpl(Inline), Op]
        public static ref readonly Cell128 load(W128 w, ReadOnlySpan<byte> src, uint offset = 0)
            => ref core.first(recover<Cell128>(slice(src, offset)));

        /// <summary>
        /// Loads a width-selected cell from a specified source beginning at a specified source-relative offset
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        [MethodImpl(Inline), Op]
        public static ref readonly Cell256 load(W256 w, ReadOnlySpan<byte> src, uint offset = 0)
            => ref core.first(recover<Cell256>(slice(src, offset)));

        /// <summary>
        /// Loads a width-selected cell from a specified source beginning at a specified source-relative offset
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        [MethodImpl(Inline), Op]
        public static ref readonly Cell512 load(W512 w, ReadOnlySpan<byte> src, uint offset = 0)
            => ref core.first(recover<Cell512>(slice(src, offset)));

        /// <summary>
        /// Loads a width-selected cell from a specified source beginning at a specified source-relative offset
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Cell8 load<T>(W8 w, ReadOnlySpan<T> src, uint offset = 0)
            where T : unmanaged
                => ref core.first(recover<T,Cell8>(slice(src, offset)));

        /// <summary>
        /// Loads a width-selected cell from a specified source beginning at a specified source-relative offset
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Cell16 load<T>(W16 w, ReadOnlySpan<T> src, uint offset = 0)
            where T : unmanaged
                => ref core.first(recover<T,Cell16>(slice(src, offset)));

        /// <summary>
        /// Loads a width-selected cell from a specified source beginning at a specified source-relative offset
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Cell32 load<T>(W32 w, ReadOnlySpan<T> src, uint offset = 0)
            where T : unmanaged
                => ref core.first(recover<T,Cell32>(slice(src, offset)));

        /// <summary>
        /// Loads a width-selected cell from a specified source beginning at a specified source-relative offset
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Cell64 load<T>(W64 w, ReadOnlySpan<T> src, uint offset = 0)
            where T : unmanaged
                => ref core.first(recover<T,Cell64>(slice(src, offset)));

        /// <summary>
        /// Loads a width-selected cell from a specified source beginning at a specified source-relative offset
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Cell128 load<T>(W128 w, ReadOnlySpan<T> src, uint offset = 0)
            where T : unmanaged
                => ref core.first(recover<T,Cell128>(slice(src, offset)));

        /// <summary>
        /// Loads a width-selected cell from a specified source beginning at a specified source-relative offset
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Cell256 load<T>(W256 w, ReadOnlySpan<T> src, uint offset = 0)
            where T : unmanaged
                => ref core.first(recover<T,Cell256>(slice(src, offset)));

        /// <summary>
        /// Loads a width-selected cell from a specified source beginning at a specified source-relative offset
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Cell512 load<T>(W512 w, ReadOnlySpan<T> src, uint offset = 0)
            where T : unmanaged
                => ref core.first(recover<T,Cell512>(slice(src, offset)));
    }
}