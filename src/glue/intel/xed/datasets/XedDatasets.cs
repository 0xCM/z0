//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    public readonly struct XedDatasets
    {
        public static ReadOnlySpan<XedDataset> all()
        {
            var src = typeof(XedDatasetKind).LiteralFields().ToReadOnlySpan();
            var count = src.Length;
            var buffer = alloc<XedDataset>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = new XedDataset(skip(src,i));
            return buffer;
        }
    }
}