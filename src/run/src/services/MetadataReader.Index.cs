//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static MetadataIndex;

    using static Konst;
    using static z;

    partial class MetadataReader
    {
        public ReadOnlySpan<ResourceIndex> GetResourceIndex()
        {
            var resources = Reader.ManifestResources.ToReadOnlySpan();
            Reader.AssemblyFiles.ToReadOnlySpan();
            var dst = span<ResourceIndex>(resources.Length);
            for(var i=0u; i<resources.Length; i++)
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