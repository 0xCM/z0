//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    [StructLayout(LayoutKind.Sequential), Record(TableId)]
    public struct CliBlobInfo : IRecord<CliBlobInfo>
    {
        public const string TableId = "cli.blob";

        public const byte FieldCount = 4;

        public Count Seq;

        public ByteSize HeapSize;

        public Address32 Offset;

        public BinaryCode Data;

        [MethodImpl(Inline)]
        public CliBlobInfo(Count seq, ByteSize heap, Address32 offset, byte[] data)
        {
            Seq = seq;
            HeapSize = heap;
            Offset = offset;
            Data = data;
        }
    }
}