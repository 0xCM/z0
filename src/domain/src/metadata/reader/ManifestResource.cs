//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Konst;
    using static z;
    using static ClrData;

    partial class ClrDataReader
    {
        [MethodImpl(Inline), Op]
        public ManifestResource Read(ManifestResourceHandle src)
            => Reader.GetManifestResource(src);

        [MethodImpl(Inline), Op]
        public ref ManifestResource Read(ManifestResourceHandle src, ref ManifestResource dst)
        {
            dst = Read(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public void Read(ReadOnlySpan<ManifestResourceHandle> src, Span<ManifestResource> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                Read(skip(src,i), ref seek(dst,i));
        }

        [MethodImpl(Inline), Op]
        public ref ManifestResourceData Read(ManifestResource src, ref ManifestResourceData dst)
        {
            dst.Name = Read(src.Name);
            dst.Offset = (ulong)src.Offset;
            dst.Attributes = src.Attributes;
            return ref dst;
        }
    }
}