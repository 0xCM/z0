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

    using static Part;

    partial class ImageMetaReader
    {
        public Index<CliUserString> ReadUserStrings()
        {
            var reader = MD;
            int size = reader.GetHeapSize(HeapIndex.UserString);
            if (size == 0)
                return sys.empty<CliUserString>();

            var values = root.list<CliUserString>();
            var handle = MetadataTokens.UserStringHandle(0);
            var i=0;

            do
            {
                values.Add(new CliUserString(seq: i++, size, CliReader.HeapOffset(handle), CliReader.Read(handle)));
                handle = reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            return values.ToArray();
        }
    }
}