//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    /// <summary>
    /// Defines a natural sequence of 16-bit cells
    /// </summary>
    public readonly ref struct HexVector16
    {
        readonly Span<Hex16> Data;

        [MethodImpl(Inline)]
        public HexVector16(Span<Hex16> src)
        {
            Data = src;
        }

        public ByteSize CellSize => 2;

        public BitWidth CellWidth => 16;

        public ByteSize VectorSize
        {
            [MethodImpl(Inline)]
            get => CellSize * CellCount;
        }

        public ref Hex16 this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Data, index);
        }

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public Span<Hex16> Cells
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref Hex16 First
        {
            [MethodImpl(Inline)]
            get => ref first(Data);
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(Data);
        }

        [MethodImpl(Inline)]
        public static implicit operator HexVector16(Hex16[] src)
            => new HexVector16(src);
    }
}