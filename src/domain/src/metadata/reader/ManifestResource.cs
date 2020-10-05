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
        public ReadOnlySpan<ManifestResourceInfo> ManifestResources()
        {
            var handles = ManifestResourceHandles();
            return Read(handles, alloc<ManifestResourceInfo>(handles.Length));
        }

        [MethodImpl(Inline), Op]
        ReadOnlySpan<ManifestResourceHandle> ManifestResourceHandles()
            => Reader.ManifestResources.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public ManifestResource Read(ManifestResourceHandle src)
            => Reader.GetManifestResource(src);

        [MethodImpl(Inline), Op]
        public ref ManifestResource Read(ManifestResourceHandle src, out ManifestResource dst)
        {
            dst = Read(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public Span<ManifestResourceInfo> Read(ReadOnlySpan<ManifestResourceHandle> src, Span<ManifestResourceInfo> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                Read(Read(skip(src,i), out var _), ref seek(dst,i));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public ref ManifestResourceInfo Read(in ManifestResource src, ref ManifestResourceInfo dst)
        {
            dst.Name = Read(src.Name);
            dst.Offset = (ulong)src.Offset;
            dst.Attributes = src.Attributes;
            return ref dst;
        }
    }
}