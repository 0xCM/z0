//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata;

    using static Konst;
    using static z;
    using static MetadataIndex;

    partial class MetadataReader
    {
        public ReadOnlySpan<ResourceIndex> GetResourceIndex()
        {
            var resources = Reader.ManifestResources.ToReadOnlySpan();
            var count = resources.Length;
            Reader.AssemblyFiles.ToReadOnlySpan();
            var dst = span<ResourceIndex>(resources.Length);
            for(var i=0u; i<count; i++)
            {
                var res = Reader.GetManifestResource(skip(resources,i));
                var name = Reader.GetString(res.Name);
                var attribs = res.Attributes;
                seek(dst,i) = new ResourceIndex(name, (MemoryAddress)res.Offset);
            }
            return dst;
        }
    }
}