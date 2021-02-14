//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public struct EncodingSegment
    {
        ulong Data;

        [MethodImpl(Inline)]
        public EncodingSegment(ulong src)
            => Data = src;

        public byte Size
        {
            [MethodImpl(Inline)]
            get => Bits.effsize(Data);
        }

        public byte Capacity
        {
            [MethodImpl(Inline)]
            get => 8;
        }

        public Span<byte> Cells
        {
            [MethodImpl(Inline)]
            get => bytes(Data);
        }

        [MethodImpl(Inline)]
        public ref byte Cell(byte index)
            => ref first(Cells);

        [MethodImpl(Inline)]
        public ushort ToUInt16()
            => (ushort)Data;

        [MethodImpl(Inline)]
        public uint ToUInt32()
            => (uint)Data;

        [MethodImpl(Inline)]
        public uint ToUInt64()
            => (uint)Data;

        public string Format()
            => Data.FormatHexData(Size);

        public override string ToString()
            => Format();


        [MethodImpl(Inline)]
        public static implicit operator EncodingSegment(ulong src)
            => new EncodingSegment(src);

        [MethodImpl(Inline)]
        public static implicit operator EncodingSegment(uint src)
            => new EncodingSegment(src);

        public static EncodingSegment Empty
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}