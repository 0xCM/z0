//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public enum ImageLiteralField : ushort
    {
        Sequence = 0,

        HeapSize = 1,

        Length = 2,

        Offset = 3,

        Value = 4,
    }

    public struct ImageLiteralFieldTable
    {
        public Count32 Sequence;

        public ByteSize HeapSize;

        public Count32 Length;

        public Address32 Offset;

        public string Value;

        [MethodImpl(Inline)]
        public ImageLiteralFieldTable(Count32 seq, ByteSize heap, Address32 offset, string value)
        {
            Sequence = seq;
            HeapSize = heap;
            Length = value.Length;
            Offset = offset;
            Value = value;
        }
    }
}