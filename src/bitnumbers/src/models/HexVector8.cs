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

    /// <summary>
    /// Defines a sequence of 8-bit cells
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly ref struct HexVector8
    {
        readonly Span<Hex8> Data;

        [MethodImpl(Inline)]
        public HexVector8(Span<Hex8> data)
        {
            Data = data;
        }

        public ByteSize CellSize => 1;

        public BitWidth CellWidth => 8;

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public ByteSize VectorSize
        {
            [MethodImpl(Inline)]
            get => CellSize * CellCount;
        }

        public Span<Hex8> Cells
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref Hex8 First
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
        public HexVector8 Slice(uint offset, uint length)
            => slice(Data, offset, length);

        public ref Hex8 this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Data,index);
        }

        [MethodImpl(Inline)]
        public static implicit operator HexVector8(Span<Hex8> src)
            => new HexVector8(src);
    }
}