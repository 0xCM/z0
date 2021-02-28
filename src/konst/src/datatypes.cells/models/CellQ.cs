//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Cells;

    public readonly struct CellQ : IDataCell
    {
        readonly Index<byte> Data;

        internal CellQ(byte[] src)
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
            => api.format(this);

        public override string ToString()
            => Format();
    }
}