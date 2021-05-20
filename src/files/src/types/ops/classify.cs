//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;

    partial class FileTypes
    {
        [Op]
        public static uint classify(ReadOnlySpan<FS.FilePath> src, Span<TypedFile> dst)
        {
            var count = src.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(src,i);
                if(lookup(skip(src,i).Ext, out var x))
                    seek(dst, counter++) = (x,path);
            }
            return counter;
        }

        public static ReadOnlySpan<TypedFile> classify(ReadOnlySpan<FS.FilePath> src)
        {
            var dst = span<TypedFile>(src.Length);
            var count = classify(src, dst);
            return slice(dst, 0, count);
        }
    }
}