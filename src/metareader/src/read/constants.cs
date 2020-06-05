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

    using static Seed;    
    using static MetadataRecords;
    using static Control;
        
    partial class MetaRead
    {                
        internal static ReadOnlySpan<ConstantValue> constants(in MetaReaderState state)
        {
            var reader = state.Reader;
            var count = ConstantCount(state);
            var dst = alloc<ConstantValue>(count);

            for (int i = 1; i <= count; i++)
            {
                var entry = reader.GetConstant(ConstantHandle(i));
                seek(dst,i-1) = new ConstantValue(
                    Sequence: i,
                    Parent: Token(state, entry.Parent),
                    Type: entry.TypeCode,
                    Value: LiteralValue(state, entry.Value)
                );
            }

            return dst;
        }
    }
}