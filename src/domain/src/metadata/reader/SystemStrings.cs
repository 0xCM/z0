//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
    using System.Reflection.Metadata.Ecma335;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    partial class PeTableReader
    {
        public ReadOnlySpan<SystemStringRecord> SystemStrings()
        {
            var reader = State.Reader;
            int size = reader.GetHeapSize(HeapIndex.String);
            if (size == 0)
                return empty<SystemStringRecord>();

            var values = new List<SystemStringRecord>();
            var handle = MetadataTokens.StringHandle(0);
            var i=0;
            do
            {
                values.Add(new SystemStringRecord(seq: i++, ImageStringSource.System, size, (Address32)reader.GetHeapOffset(handle), reader.GetString(handle)));
                handle = reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            return values.ToArray();
        }
    }
}