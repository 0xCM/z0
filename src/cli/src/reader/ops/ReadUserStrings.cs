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

    using static Images;
    using static Part;
    using static memory;

    partial class ImageMetaReader
    {
        public Index<UserString> ReadUserStrings()
        {
            var reader = MD;
            int size = reader.GetHeapSize(HeapIndex.UserString);
            if (size == 0)
                return sys.empty<UserString>();

            var values = root.list<UserString>();
            var handle = MetadataTokens.UserStringHandle(0);
            var i=0;

            do
            {
                values.Add(new UserString(seq: i++, size, CliReader.HeapOffset(handle), CliReader.Read(handle)));
                handle = reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            return values.ToArray();
        }
    }
}