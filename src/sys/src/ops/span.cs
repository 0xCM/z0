//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;
    
    partial struct sys
    {
        /// <summary>
        /// Allocates storage for a specified number of T-cells
        /// </summary>
        /// <param name="count">The cell allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Options), Op, Closures(Closure)]
        public static Span<T> span<T>(int count)
            => xsys.span<T>(count);

        /// <summary>
        /// Allocates storage for a specified number of T-cells
        /// </summary>
        /// <param name="count">The cell allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Options), Op, Closures(Closure)]
        public static Span<T> span<T>(uint count)
            => xsys.span<T>((int)count);

        [MethodImpl(Options), Op, Closures(Closure)]
        public static Span<T> span<T>(IEnumerable<T> src)
            => xsys.span(src);
    }
}