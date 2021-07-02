//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class text
    {
        /// <summary>
        /// Inserts a string into the intern pool if it is not already there and, in any case, returns the string's address
        /// </summary>
        /// <param name="src">The text to intern</param>
        [MethodImpl(Inline), Op]
        public static StringAddress intern(string src)
            => address(string.Intern(src));
    }
}