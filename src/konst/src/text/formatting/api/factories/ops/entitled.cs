//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Formatters
    {
        /// <summary>
        /// Creates a <see cref='Entitled{T}'/> formatter
        /// </summary>
        /// <param name="tf">A tile formatter</param>
        /// <param name="cf">A content formatter</param>
        /// <typeparam name="T">The format target type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Entitled<T> entitled<T>(TitleFormatter<T> tf, Formatter<T> cf)
            => new Entitled<T>(tf, cf);

        /// <summary>
        /// Creates an entitled formatter that provides formatting, entitling and entitled formatting
        /// from a format/title render function pair
        /// </summary>
        /// <param name="fx">The format render function</param>
        /// <param name="tx">The title render function</param>
        /// <typeparam name="T">The type of element to render</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Entitled<T> entitled<T>(FormatFunctions.FormatTitle<T> tx, FormatFunctions.Format<T> fx)
            => new Entitled<T>(title(tx), content(fx));
    }
}