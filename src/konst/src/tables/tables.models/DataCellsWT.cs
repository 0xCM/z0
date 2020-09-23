//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct DataCells<W,T>
        where W : unmanaged, IDataWidth
    {
        public readonly DataCell<W,T>[] Data;

        [MethodImpl(Inline)]
        public DataCells(DataCell<W,T>[] data)
            => Data = data;

        [MethodImpl(Inline)]
        public ref DataCell<W,T> Cell(uint index)
            => ref Data[index];

        public ref DataCell<W,T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public uint CellWidth
        {
            [MethodImpl(Inline)]
            get => (uint)Widths.data<W>();
        }

        public uint DataSize
        {
            [MethodImpl(Inline)]
            get => (CellCount* CellWidth)/8;
        }

        public ulong DataWidth
        {
            [MethodImpl(Inline)]
            get => ((ulong)CellCount * (ulong)CellWidth);
        }
    }
}