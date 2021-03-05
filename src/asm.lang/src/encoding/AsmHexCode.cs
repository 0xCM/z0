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

    using api = AsmBytes;

    public struct AsmHexCode
    {
        internal Cell128 Data;

        [MethodImpl(Inline)]
        internal AsmHexCode(Cell128 data)
            => Data = data;

        public byte Size
        {
            [MethodImpl(Inline)]
            get => Cells.cell8(Data, 15);
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => slice(bytes(Data), 0, 15);
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
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmHexCode(BinaryCode src)
            => api.hexcode(src.View);

        [MethodImpl(Inline)]
        public static implicit operator AsmHexCode(ReadOnlySpan<byte> src)
            => api.hexcode(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmHexCode(byte[] src)
            => api.hexcode(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmHexCode(string src)
            => api.hexcode(src);

        public static AsmHexCode Empty
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}