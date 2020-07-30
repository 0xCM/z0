//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class text
    {
        /// <summary>
        /// Tests whether the source string is nonempty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Inline), Op]
        public static bool nonempty(string src)
            => !string.IsNullOrEmpty(src);

        /// <summary>
        /// Test whether the source is a nonempty string
        /// </summary>
        /// <param name="src">The object to evaluate</param>
        [MethodImpl(Inline), Op]
        public static bool nonempty(object src) 
            => src is string s ? sys.nonempty(s) : false;
    }
}