//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;

    [StructLayout(LayoutKind.Sequential)]
    public readonly ref struct HexVector16<N>
        where N : unmanaged, ITypeNat
    {
        readonly Span<Hex16> Data;

        [MethodImpl(Inline)]
        internal HexVector16(Span<Hex16> data)
        {
            Data = data;
        }

        public static ByteSize CellSize => 2;

        public static BitWidth CellWidth => 16;

        public static uint CellCount
        {
            [MethodImpl(Inline)]
            get => (uint)TypeNats.value<N>();
        }

        public static ByteSize VectorSize
        {
            [MethodImpl(Inline)]
            get => CellCount*CellSize;
        }

        public static BitWidth VectorWidth
        {
            [MethodImpl(Inline)]
            get => CellCount*CellWidth;
        }

        public ref Hex16 this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Data, index);
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(Data);
        }

        [MethodImpl(Inline)]
        public static implicit operator HexVector16(HexVector16<N> src)
            => new HexVector16(src.Data);
    }
}