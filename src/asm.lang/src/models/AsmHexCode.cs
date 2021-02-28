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

    public struct AsmHexCode
    {
        ulong Data;

        [MethodImpl(Inline)]
        public AsmHexCode(ulong src)
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
        public static implicit operator AsmHexCode(ulong src)
            => new AsmHexCode(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmHexCode(uint src)
            => new AsmHexCode(src);

        public static AsmHexCode Empty
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}