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
    
    partial class ImgMetadataReader
    {        
        [MethodImpl(Inline)]
        internal static ReadOnlySpan<R> empty<R>()
            => ReadOnlySpan<R>.Empty;

        internal static ReadOnlySpan<ImgStringRecord> strings(in ReaderState state)
        {
            var reader = state.Reader;
            int size = reader.GetHeapSize(HeapIndex.String);
            if (size == 0)
                return empty<ImgStringRecord>();

            var values = new List<ImgStringRecord>();
            var handle = MetadataTokens.StringHandle(0);
            var i=0;
            do
            {
                values.Add(new ImgStringRecord(
                    Sequence: i++,
                    ImgStringSource.System,
                    HeapSize:size, 
                    Offset: reader.GetHeapOffset(handle), 
                    Value: reader.GetString(handle))
                    );
            
                handle = reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);
            
            return values.ToArray();            
        }

        internal static ReadOnlySpan<ImgStringRecord> ustrings(in ReaderState state)
        {
            var reader = state.Reader;
            int size = reader.GetHeapSize(HeapIndex.UserString);
            if (size == 0)
                return empty<ImgStringRecord>();

            var values = new List<ImgStringRecord>();
            var handle = MetadataTokens.UserStringHandle(0);
            var i=0;
            do
            {                
                values.Add(new ImgStringRecord(
                    Sequence: i++,
                    ImgStringSource.User,
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