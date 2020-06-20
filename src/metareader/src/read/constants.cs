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

    using static Konst;    
    using static MetadataRecords;
    using static Root;
        
    partial class MetadataRead
    {                
        internal static ReadOnlySpan<ConstantRecord> constants(in ReaderState state)
        {
            var reader = state.Reader;
            var count = ConstantCount(state);
            var dst = alloc<ConstantRecord>(count);

            for (int i = 1; i <= count; i++)
            {
                var entry = reader.GetConstant(ConstantHandle(i));
                seek(dst,i-1) = new ConstantRecord(
                    Sequence: i,
                    Parent: Token(state, entry.Parent),
                    Type: entry.TypeCode,
                    Value: LiteralValue(state, entry.Value,i)
                );
            }

            return dst;
        }
    }
}