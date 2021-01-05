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
    public struct CliLiteralInfo : IRecord<CliLiteralInfo>
    {
        public const string TableId = "cli.literal";

        public const byte FieldCount = 4;

        public Count Sequence;

        public ByteSize HeapSize;

        public Count Length;

        public Address32 Offset;

        public string Value;

        [MethodImpl(Inline)]
        public CliLiteralInfo(Count seq, ByteSize heap, Address32 offset, string value)
        {
            Sequence = seq;
            HeapSize = heap;
            Length = value.Length;
            Offset = offset;
            Value = value;
        }
    }
}