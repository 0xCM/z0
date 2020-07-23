//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class text
    {
        /// <summary>
        /// Formats the pair of strings represented by repsective character spans
        /// </summary>
        /// <param name="a">The leading content</param>
        /// <param name="b">The trailing content</param>
        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<char> a, ReadOnlySpan<char> b)
            => string.Concat(a,b);

        /// <summary>
        /// Formats a pattern using an arbitrary kind/number of arguments
        /// </summary>
        /// <param name="pattern">The source pattern</param>
        /// <param name="args">The pattern arguments</param>
        [MethodImpl(Inline), Op]
        public static string format(string pattern, params object[] args)
            => string.Format(pattern, args);

        /// <summary>
        /// Formats anything
        /// </summary>
        /// <param name="rest">The formattables to be rendered and concatenated</param>
        [MethodImpl(Inline), Op]
        public static string format(object first)
            =>  first is ITextual t ? t.Format() : first?.ToString() ?? EmptyString;
    }
}