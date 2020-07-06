//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {
        const NumericKind Closure = Integers8x64k;

        /// <summary>
        /// A string-specific coalescing operation
        /// </summary>
        /// <param name="test">The subject string</param>
        /// <param name="replace">The replacement value if blank</param>
        [MethodImpl(Inline)]
        public static string ifempty(string test, string replace)
            => string.IsNullOrWhiteSpace(test) ? replace ?? string.Empty : test;

        /// <summary>
        /// Creates a span from an array
        /// </summary>
        /// <param name="src">A reference to the leading cell</param>
        /// <param name="count">The source cell count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> span<T>(T[] src)
            => src;


    }

    public static partial class XTend
    {
        
    }
}