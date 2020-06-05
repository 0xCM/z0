//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Seed;    
    using static MetadataRecords;
    
    partial class MetaRead
    {        
        internal static ReadOnlySpan<StringValue> strings(in MetaReaderState state)
        {
            var reader = state.Reader;
            int size = reader.GetHeapSize(HeapIndex.String);
            if (size == 0)
                return MetaFormat.empty<StringValue>();

            var values = new List<StringValue>();
            var handle = MetadataTokens.StringHandle(0);
            var i=0;
            do
            {
                values.Add(new StringValue(
                    Sequence: i++,
                    HeapSize:size, 
                    Offset: reader.GetHeapOffset(handle), 
                    Value: reader.GetString(handle))
                    );
            
                handle = reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);
            
            return values.ToArray();            
        }

        internal static ReadOnlySpan<StringValue> ustrings(in MetaReaderState state)
        {
            var reader = state.Reader;
            int size = reader.GetHeapSize(HeapIndex.UserString);
            if (size == 0)
                return MetaFormat.empty<StringValue>();

            var values = new List<StringValue>();
            var handle = MetadataTokens.UserStringHandle(0);
            var i=0;
            do
            {                
                values.Add(new StringValue(
                    Sequence: i++,
                    HeapSize: size, 
                    Offset: reader.GetHeapOffset(handle), 
                    Value: reader.GetUserString(handle)
                    ));

                handle = reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);
            
            return values.ToArray();
        }
    }
}