//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct core
    {
        /// <summary>
        /// Retrieves a pointer to a string that, hopefully (shouldn't)  move
        /// </summary>
        /// <param name="src">The source string</param>
        [MethodImpl(Inline), Op]
        public static unsafe char* pchar(string src) 
            => gptr(first(span(src)));
    }
}