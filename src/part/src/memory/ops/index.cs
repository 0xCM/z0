//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct memory
    {
        /// <summary>
        /// Allocates storage for a specified number of T-cells and returns the buffers as a <see cref='Index{T}'/>
        /// </summary>
        /// <param name="count">The cell allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Index<T> index<T>(int count)
            => sys.alloc<T>(count);

        /// <summary>
        /// Allocates storage for a specified number of T-cells and returns the buffers as a <see cref='Index{T}'/>
        /// </summary>
        /// <param name="count">The cell allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Index<T> index<T>(uint count)
            => sys.alloc<T>(count);

        /// <summary>
        /// Allocates storage for a specified number of T-cells and returns the buffers as a <see cref='Index{T}'/>
        /// </summary>
        /// <param name="count">The cell allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Index<T> index<T>(long count)
            => sys.alloc<T>(count);

        /// <summary>
        /// Allocates storage for a specified number of T-cells and returns the buffers as a <see cref='Index{T}'/>
        /// </summary>
        /// <param name="count">The cell allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Index<T> index<T>(ulong count)
            => sys.alloc<T>(count);
    }
}