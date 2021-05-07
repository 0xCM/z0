//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Part;
    using static memory;
    using static CliRecords;

    partial class ImageMetaReader
    {
        [MethodImpl(Inline), Op]
        public ReadOnlySpan<ManifestResourceInfo> ReadResDescriptions()
        {
            var handles = CliReader.ResourceHandles();
            return ReadResDescriptions(handles, alloc<ManifestResourceInfo>(handles.Length));
        }

        [MethodImpl(Inline), Op]
        public Span<ManifestResourceInfo> ReadResDescriptions(ReadOnlySpan<ManifestResourceHandle> src, Span<ManifestResourceInfo> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                ReadResDescription(ReadResource(skip(src,i), out var _), ref seek(dst,i));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public ref ManifestResourceInfo ReadResDescription(in ManifestResource src, ref ManifestResourceInfo dst)
        {
            dst.Name = CliReader.Read(src.Name);
            dst.Offset = (ulong)src.Offset;
            dst.Attributes = src.Attributes;
            return ref dst;
        }
    }
}