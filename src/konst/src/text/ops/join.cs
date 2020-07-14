//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.IO;

    using static Konst;
    using static z;

    partial class text
    {
        /// <summary>
        /// Functional equivalalent of <see cref="string.Join(string, object[])"/>
        /// </summary>
        /// <param name="values">The values to be rendered as text</param>
        /// <param name="sep">The item delimiter</param>
        public static string join<T>(string sep, IEnumerable<T> values)
            => string.Join(sep, values);

        /// <summary>
        /// Functional equivalalent of <see cref="string.Join(char, object[])"/>
        /// </summary>
        /// <param name="values">The values to be rendered as text</param>
        /// <param name="sep">The item delimiter</param>
        public static string join<T>(char sep, IEnumerable<T> values)
            => string.Join(sep, values);
    }
}