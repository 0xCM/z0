//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static ReaderInternals;
        
    partial class PartReader
    {                
        internal static ReadOnlySpan<ConstantRecord> constants(in ReaderState state)
        {            
            var reader = state.Reader;
            var count = ConstantCount(state);
            var dst = Spans.alloc<ConstantRecord>(count);
            for(var i=1; i<= count; i++)
            {
                var k = ConstantHandle(i);
                var entry = reader.GetConstant(k);
                var parent = describe(state, entry.Parent);
                var blob = reader.GetBlobBytes(entry.Value);
                z.seek(dst,(uint)i - 1) = new ConstantRecord(
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