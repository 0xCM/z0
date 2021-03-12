//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CellQ : IDataCell
    {
        readonly Index<byte> Data;

        public CellQ(byte[] src)
            => Data = src;

        public CellKind Kind
        {
            [MethodImpl(Inline)]
            get => (CellKind)(Width);
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public uint Width
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length*8;
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public string Format()
            => Kind switch{
                CellKind.Cell8 => memory.first(Bytes).FormatHex(),
                CellKind.Cell16 => memory.first16u(Bytes).FormatHex(),
                CellKind.Cell32 => memory.first32u(Bytes).FormatHex(),
                CellKind.Cell64 => memory.first64u(Bytes).FormatHex(),
                _ => Bytes.FormatHex()
            };

        public override string ToString()
            => Format();
    }
}