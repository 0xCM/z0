//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static OpacityKind;
    
    partial struct sys
    {
        [MethodImpl(Options), Opaque(StringToCharSpan)]
        public static ReadOnlySpan<char> span(string src)
            => src;

        /// <summary>
        /// Allocates storage for a specified number of T-cells
        /// </summary>
        /// <param name="count">The cell allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Options), Opaque(AllocSpan), Closures(Closure)]
        public static Span<T> span<T>(int count)
            => alloc<T>(count);

        /// <summary>
        /// Allocates storage for a specified number of T-cells
        /// </summary>
        /// <param name="count">The cell allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Options), Opaque(AllocSpan), Closures(Closure)]
        public static Span<T> span<T>(uint count)
            => alloc<T>(count);
    }
}