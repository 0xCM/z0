//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static ReaderInternals;
        
    partial class ImgMetadataReader
    {                
        internal static ReadOnlySpan<ImgConstantRecord> constants(in ReaderState state)
        {            
            var reader = state.Reader;
            var count = ConstantCount(state);
            var dst = Spans.alloc<ImgConstantRecord>(count);
            for(var i=1; i<= count; i++)
            {
                var k = ConstantHandle(i);
                var entry = reader.GetConstant(k);
                var parent = describe(state, entry.Parent);
                var blob = reader.GetBlobBytes(entry.Value);
                z.seek(dst,(uint)i - 1) = new ImgConstantRecord(
                    Sequence: i,
                    Parent: parent ?? HandleInfo.Empty,
                    type: entry.TypeCode,
                    value: blob
                );
            }

            return dst;
        }
    }
}