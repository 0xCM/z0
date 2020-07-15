//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
                
    partial struct sys
    {
        /// <summary>
        /// Formats a character span as a string
        /// </summary>
        /// <param name="src">The source characters</param>
        [MethodImpl(Options), Op]
        public static string format(ReadOnlySpan<char> src)
            => proxy.format(src);
    }
}