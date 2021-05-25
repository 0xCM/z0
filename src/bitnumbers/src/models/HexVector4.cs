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
    public readonly ref struct HexVector4
    {
        readonly Span<byte> Data;

        [MethodImpl(Inline)]
        public HexVector4(Span<byte> data)
        {
            Data = data;
        }

        public BitWidth CellWidth => 4;

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length * 2;
        }

        public ByteSize VectorSize
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(Data);
        }

    }
}