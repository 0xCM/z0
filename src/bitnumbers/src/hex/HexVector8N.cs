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
    public readonly ref struct HexVector8<N>
        where N : unmanaged, ITypeNat
    {
        readonly Span<Hex8> Data;

        [MethodImpl(Inline)]
        internal HexVector8(Span<Hex8> data)
        {
            Data = data;
        }

        public ByteSize CellSize => 1;

        public BitWidth CellWidth => 8;

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => (uint)TypeNats.value<N>();
        }

        public ref Hex8 this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Data, index);
        }

        public ByteSize VectorSize
        {
            [MethodImpl(Inline)]
            get => CellCount*CellSize;
        }

        public BitWidth VectorWidth
        {
            [MethodImpl(Inline)]
            get => CellCount*CellWidth;
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(Data);
        }
    }
}