//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Can this ever be a good way to solve your problem?
        /// </summary>
        /// <param name="src">The buffer to let it be what it wants</param>
        [MethodImpl(Inline), Op]
        public static Span<char> liberate(ReadOnlySpan<char> src)
            => z.cover(z.first(z.edit(src)),src.Length);            
    }
}