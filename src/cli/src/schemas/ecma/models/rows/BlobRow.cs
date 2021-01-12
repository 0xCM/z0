//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct BlobRow : IRecord<BlobRow>
    {
        public const string TableId = "ecma.blob";

        public Count Sequence;

        public ByteSize HeapSize;

        public Address32 Offset;

        public ByteSize DataSize;

        public BinaryCode Data;
    }
}