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
        Cell128 Data;

        [MethodImpl(Inline)]
        internal AsmHexCode(Cell128 data)
        {
            Data = data;
        }

        public byte Size
        {
            [MethodImpl(Inline)]
            get => Cells.cell8(Data, 15);
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(Data);
        }

        [MethodImpl(Inline)]
        public ref byte Cell(byte index)
            => ref first(Bytes);

        [MethodImpl(Inline)]
        public ushort ToUInt16()
            => (ushort)Data.Lo;

        [MethodImpl(Inline)]
        public uint ToUInt32()
            => (uint)Data.Lo;

        [MethodImpl(Inline)]
        public uint ToUInt64()
            => (uint)Data.Lo;

        public string Format()
            => Data.FormatHexData(Size);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmHexCode(BinaryCode src)
            => asm.encoding(src.View);

        public static AsmHexCode Empty
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}