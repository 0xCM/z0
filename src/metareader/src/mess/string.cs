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
    using System.Runtime;

    using static Konst;

    partial class PeMetaReader
    {
        [MethodImpl(Inline)]
        internal static ReadOnlySpan<R> empty<R>()
            => ReadOnlySpan<R>.Empty;

        internal static ReadOnlySpan<MemberString> MemberStrings(in ReaderState state)
        {
            var reader = state.Reader;
            int size = reader.GetHeapSize(HeapIndex.String);
            if (size == 0)
                return empty<MemberString>();

            var values = new List<MemberString>();
            var handle = MetadataTokens.StringHandle(0);
            var i=0;
            do
            {
                var dst = default(MemberString);
                dst.Sequence = i++;
                dst.HeapSize = size;
                dst.Offset = (Address32)reader.GetHeapOffset(handle);
                dst.Content = reader.GetString(handle);
                handle = reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            return values.ToArray();
        }

        internal static ReadOnlySpan<ImageString> strings(in ReaderState state)
        {
            var reader = state.Reader;
            int size = reader.GetHeapSize(HeapIndex.String);
            if (size == 0)
                return empty<ImageString>();

            var values = new List<ImageString>();
            var handle = MetadataTokens.StringHandle(0);
            var i=0;
            do
            {
                values.Add(new ImageString(
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

        internal static ReadOnlySpan<ImageString> ustrings(in ReaderState state)
        {
            var reader = state.Reader;
            int size = reader.GetHeapSize(HeapIndex.UserString);
            if (size == 0)
                return empty<ImageString>();

            var values = new List<ImageString>();
            var handle = MetadataTokens.UserStringHandle(0);
            var i=0;
            do
            {
                values.Add(new ImageString(
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