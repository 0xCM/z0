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
        /// Tests whether the source string is non-blank where blank := {null | whitespace}
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Options), Op]
        public static bool nonempty(string src)
            => proxy.nonempty(src);
    }
}