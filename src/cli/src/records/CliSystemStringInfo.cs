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
    public struct CliSystemStringInfo : IRecord<CliSystemStringInfo>
    {
        public const string TableId = "cli.strings.system";

        public const byte FieldCount = 6;

        public Count Sequence;

        public CliStringRecord.Source Source;

        public ByteSize HeapSize;

        public Count Length;

        public Address32 Offset;

        public string Content;

        [MethodImpl(Inline)]
        public CliSystemStringInfo(Count seq, CliStringRecord.Source src, ByteSize heap, Address32 offset, string data)
        {
            Sequence = seq;
            Source = src;
            HeapSize = heap;
            Length = data.Length;
            Offset = offset;
            Content = data;
        }
    }
}