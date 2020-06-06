//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;    
    using static MetadataRecords;
    using static Control;
    
    partial class MetadataRead
    {        
        internal static ReadOnlySpan<ResourceRecord> resources(in ReaderState state)
        {
            var handles = state.Reader.ManifestResources.ToReadOnlySpan();
            var count = handles.Length;
            var dst = alloc<ResourceRecord>(count);

            for(var i=0; i<count; i++)
            {
                ref readonly var handle = ref skip(handles,i);
                var entry = state.Reader.GetManifestResource(handle);
                seek(dst,i) = new ResourceRecord(
                        Name: MetadataRead.Literal(state, entry.Name,i),
                        Attribute: entry.Attributes.ToString(),
                        Offset: entry.Offset,
                        Implementation: MetadataRead.Token(state, entry.Implementation)
                );
            }
            return dst;
        }

    }
}