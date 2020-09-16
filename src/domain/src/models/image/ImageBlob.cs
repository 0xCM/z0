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

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageBlob
    {
        public Count Seq;

        public ByteSize HeapSize;

        public Address32 Offset;

        public BinaryCode Data;

        [MethodImpl(Inline)]
        public ImageBlob(Count seq, ByteSize heap, Address32 offset, byte[] data)
        {
            Seq = seq;
            HeapSize = heap;
            Offset = offset;
            Data = data;
        }
    }

    public enum ImageBlobField : ushort
    {
        Sequence = 0,

        HeapSize = 1,

        Offset = 2,

        Value = 3,
    }

    public enum ImageBlobFieldWidth : ushort
    {
        Sequence = 12,

        HeapSize = 12,

        Offset = 12,

        Value = 30,
    }
}