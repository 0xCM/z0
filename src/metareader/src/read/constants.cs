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
        internal static ReadOnlySpan<ConstantRecord> constants(in ReaderState state)
        {            
            var reader = state.Reader;
            var count = ConstantCount(state);
            var dst = Spans.alloc<ConstantRecord>(count);
            for(var i=1; i<= count; i++)
            {
                var entry = reader.GetConstant(ConstantHandle(i));
                Root.seek(dst,i - 1) = new ConstantRecord(
                    Sequence: i,
                    Parent: token(state, entry.Parent),
                    Type: entry.TypeCode,
                    data: record(state, entry.Value,i)
                );
            }

            return dst;
        }
    }
}