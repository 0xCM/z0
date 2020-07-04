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
        /// Creates an entitled formatter that provides formatting, entitling and entitled formatting
        /// </summary>
        /// <param name="fContent">The content formatter to use</param>
        /// <param name="fTitle">The title formatter to use</param>
        /// <typeparam name="T">The type of element to render</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Entitled<T> entitled<T>(TitleFormatter<T> fTitle, Formatter<T> fContent)
            => new Entitled<T>(fTitle, fContent);

        /// <summary>
        /// Creates an entitled formatter that provides formatting, entitling and entitled formatting
        /// from a format/title render function pair
        /// </summary>
        /// <param name="rFomat">The format render function</param>
        /// <param name="rTitle">The title render function</param>
        /// <typeparam name="T">The type of element to render</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Entitled<T> entitled<T>(TitleRender<T> rTitle, FormatRender<T> rFomat)
            => new Entitled<T>(title(rTitle), content(rFomat));
    }
}