//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;
        
    [ApiHost]
    public readonly partial struct Format
    {
        public static string format<T>(ReadOnlySpan<T> src, string delimiter)            
            where T : ITextual
                => concat(items(src),delimiter);
    }
}