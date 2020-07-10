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

    using static OpacityKind;
    
    partial struct sys
    {
        [MethodImpl(NotInline), Opaque(StringToCharSpan)]
        public static ReadOnlySpan<char> span(string src)
            => src;

        /// <summary>
        /// Allocates storage for a specified number of T-cells
        /// </summary>
        /// <param name="count">The cell allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(NotInline), Opaque(AllocSpan), Closures(Closure)]
        public static Span<T> span<T>(int count)
            => alloc<T>(count);

        /// <summary>
        /// Allocates storage for a specified number of T-cells
        /// </summary>
        /// <param name="count">The cell allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(NotInline), Opaque(AllocSpan), Closures(Closure)]
        public static Span<T> span<T>(uint count)
            => alloc<T>(count);

        [MethodImpl(NotInline), Opaque(EnumerableToSpan), Closures(Closure)]
        public static Span<T> span<T>(IEnumerable<T> src)
            => src.ToArray();
    }
}