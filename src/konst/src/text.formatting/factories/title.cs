//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Formatters
    {
        /// <summary>
        /// Creates a title formatter from a rendering function render:T -> string
        /// </summary>
        /// <param name="fx">A function that produces text from an element value</param>
        /// <typeparam name="T">The type of element to render</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static TitleFormatter<T> title<T>(FormatFunctions.FormatTitle<T> fx)
            => new TitleFormatter<T>(fx);
    }
}