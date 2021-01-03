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
        /// Creates a formatter from a rendering function render:T -> string
        /// </summary>
        /// <param name="render">A function that produces text from an element value</param>
        /// <typeparam name="T">The type of element to render</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Formatter<T> content<T>(FormatFunctions.Format<T> render)
            => new Formatter<T>(render);

        [MethodImpl(Inline), Closures(Closure)]
        public static BitFormatter<T> bits<T>()
            where T : struct
                => BitFormatter.create<T>();
    }
}