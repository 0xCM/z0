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
        /// Formats a custom-formattable elements
        /// </summary>
        /// <param name="src">The source element</param>
        /// <typeparam name="T">The element type</typeparam>
        
        [MethodImpl(Inline)]
        public static string format<T>(T src)
            where T : struct, ITextual
                => src.Format();

        /// <summary>
        /// Produces a sequence of formatted strings given a sequence of custom-formattable elements
        /// </summary>
        /// <param name="src">The source element</param>
        /// <typeparam name="T">The element type</typeparam>
        public static string[] format<T>(params T[] src)
            where T : struct, ITextual
                => src.Select(x => x.Format());

        /// <summary>
        /// Formats the pair of strings represented by repsective character spans
        /// </summary>
        /// <param name="a">The leading content</param>
        /// <param name="b">The trailing content</param>
        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<char> a, ReadOnlySpan<char> b)
            => string.Concat(a,b);

        /// <summary>
        /// Formats anything
        /// </summary>
        /// <param name="rest">The formattables to be rendered and concatenated</param>
        [MethodImpl(Inline), Op]
        public static string format(object first)
            =>  first is ITextual t ? t.Format() : first?.ToString() ?? EmptyString;
    }
}