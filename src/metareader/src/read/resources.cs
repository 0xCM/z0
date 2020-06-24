//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;    
    using static PartRecords;
    using static ReaderInternals;
    
    partial class PartReader
    {        
        internal static ReadOnlySpan<ResourceRecord> resources(in ReaderState state)
        {
            var handles = state.Reader.ManifestResources.ToReadOnlySpan();
            var count = handles.Length;
            var dst = Spans.alloc<ResourceRecord>(count);

            for(var i=0; i<count; i++)
            {
                ref readonly var handle = ref Root.skip(handles,i);
                var entry = state.Reader.GetManifestResource(handle);
                Root.seek(dst,i) = new ResourceRecord(
                        Name: literal(state, entry.Name,i),
                        Attribute: entry.Attributes.ToString(),
                        Offset: entry.Offset,
                        Implementation: token(state, entry.Implementation)
                );
            }
            return dst;
        }
    }
}