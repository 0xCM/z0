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

    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public static string @string(ReadOnlySpan<char> src)
            => sys.@string(src);

        /// <summary>
        /// Returns a string of length 1 that corresponds to the specified asci code
        /// </summary>
        /// <param name="code">The asci code</param>
        [MethodImpl(Inline), Op]
        public static string @string(AsciCharCode code)
        {
            const string buffer = " ";
            edit(buffer) = (char)code;
            return buffer;
        }
    }
}