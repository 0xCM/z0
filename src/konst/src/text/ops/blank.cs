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
        /// Tests whether the source string is blank := {null | empty}
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Inline), Op]
        public static bool blank(string src)
            => sys.blank(src);
    }
}