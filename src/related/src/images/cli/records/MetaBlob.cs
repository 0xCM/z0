//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct ImageRecords
    {
        [Record(TableId), StructLayout(LayoutKind.Sequential)]
        public struct MetaBlob : IRecord<MetaBlob>
        {
            public const string TableId = "image.blob";

            public Count Sequence;

            public ByteSize HeapSize;

            public Address32 Offset;

            public ByteSize DataSize;

            public BinaryCode Data;
        }
    }
}