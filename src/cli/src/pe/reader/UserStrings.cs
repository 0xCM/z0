//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata.Ecma335;
    using static Images;

    partial class PeTableReader
    {
        public Index<UserString> UserStrings()
        {
            var reader = State.Reader;
            int size = reader.GetHeapSize(HeapIndex.UserString);
            if (size == 0)
                return sys.empty<UserString>();

            var values = root.list<UserString>();
            var handle = MetadataTokens.UserStringHandle(0);
            var i=0;

            do
            {
                values.Add(new UserString(seq: i++, size, offset(reader,handle), ustring(reader,handle)));
                handle = reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            return values.ToArray();
        }
    }
}