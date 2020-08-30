//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct XedOps
    {
        [MethodImpl(Inline), Op]
        public static Span<string> format(in ListedFiles src)
        {
            var sources = src.View;
            var count = sources.Length;
            var dst = span<string>(count);
            for(var i=0u; i<count; i++)
                seek(dst,i) = FS.format(skip(sources,i));
            return dst;
        }
    }
}