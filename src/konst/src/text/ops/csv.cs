//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class text
    {
        /// <summary>
        /// Renders a content array as a comma-separated list of values
        /// </summary>
        /// <param name="content">The data to delimit and format</param>
        [MethodImpl(Inline), Op]
        public static string csv(object o1, object o2, params object[] content)
            => string.Join(Chars.Comma, o1, o2) + string.Join(Chars.Comma, content);
    }
}