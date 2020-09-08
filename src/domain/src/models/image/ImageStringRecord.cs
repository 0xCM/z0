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

    public enum ImgStringSource : byte
    {
        System = 1,

        User = 2,
    }

    public enum ImageStringField : ushort
    {
        Sequence,

        Source,

        HeapSize,

        Length,

        Offset,

        Value,
    }

    public enum ImageStringFieldWidth : ushort
    {
        Sequence = 12,

        Source = 12,

        HeapSize = 12,

        Length = 12,

        Offset = 12,

        Value = 12,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageStringRecord
    {
        public Count32 Sequence;

        public ImgStringSource Source;

        public ByteSize HeapSize;

        public Count32 Length;

        public Address32 Offset;

        public string Content;

        [MethodImpl(Inline)]
        public ImageStringRecord(Count32 seq, ImgStringSource src, ByteSize heap, Address32 offset, string data)
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