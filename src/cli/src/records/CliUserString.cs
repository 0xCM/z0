//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    [StructLayout(LayoutKind.Sequential), Record(TableId)]
    public struct CliUserString : IRecord<CliUserString>
    {
        public const string TableId = "cli.strings.user";

        public Count Sequence;

        public CliStringRecord.Source Source;

        public ByteSize HeapSize;

        public Count Length;

        public Address32 Offset;

        public string Content;

        [MethodImpl(Inline)]
        public CliUserString(Count seq, CliStringRecord.Source src, ByteSize heap, Address32 offset, string data)
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