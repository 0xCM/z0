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

    using static Konst;    
    using static PartRecords;
    
    partial class PartReader
    {        
        [MethodImpl(Inline)]
        internal static ReadOnlySpan<R> empty<R>()
            => ReadOnlySpan<R>.Empty;

        internal static ReadOnlySpan<StringValueRecord> strings(in ReaderState state)
        {
            var reader = state.Reader;
            int size = reader.GetHeapSize(HeapIndex.String);
            if (size == 0)
                return empty<StringValueRecord>();

            var values = new List<StringValueRecord>();
            var handle = MetadataTokens.StringHandle(0);
            var i=0;
            do
            {
                values.Add(new StringValueRecord(
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

        internal static ReadOnlySpan<StringValueRecord> ustrings(in ReaderState state)
        {
            var reader = state.Reader;
            int size = reader.GetHeapSize(HeapIndex.UserString);
            if (size == 0)
                return empty<StringValueRecord>();

            var values = new List<StringValueRecord>();
            var handle = MetadataTokens.UserStringHandle(0);
            var i=0;
            do
            {                
                values.Add(new StringValueRecord(
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