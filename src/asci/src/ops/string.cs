//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static core;

    partial struct Asci
    {
        [MethodImpl(Inline), Op]
        public static string @string(ReadOnlySpan<char> src)
            => sys.@string(src);

        /// <summary>
        /// Returns a string of length 1 that corresponds to the specified asci code
        /// </summary>
        /// <param name="code">The asci code</param>
        [MethodImpl(Inline), Op]
        public static string @string(AsciCode code)
        {
            const string buffer = " ";
            edit16c(buffer) = (char)code;
            return buffer;
        }
    }
}