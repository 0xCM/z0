//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata.Ecma335;

    using static ImageRecords;
    using static CliRecords;

    partial class PeTableReader
    {
        public Index<CliSystemString> SystemStrings()
        {
            var reader = Stream.Reader;
            int size = reader.GetHeapSize(HeapIndex.String);
            if (size == 0)
                return sys.empty<CliSystemString>();

            var values = root.list<CliSystemString>();
            var handle = MetadataTokens.StringHandle(0);
            var i=0;
            do
            {
                values.Add(new CliSystemString(seq: i++, size, (Address32)reader.GetHeapOffset(handle), reader.GetString(handle)));
                handle = reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            return values.ToArray();
        }
    }
}