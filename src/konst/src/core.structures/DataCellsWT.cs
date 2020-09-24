//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct DataCells<W,T> : ITableSpan<DataCells<W,T>,DataCell<W,T>>
        where W : unmanaged, IDataWidth
        where T : struct
    {
        readonly TableSpan<DataCell<W,T>> Data;

        [MethodImpl(Inline)]
        public DataCells(DataCell<W,T>[] data)
            => Data = data;

        [MethodImpl(Inline)]
        public static implicit operator DataCells<W,T>(DataCell<W,T>[] src)
            => new DataCells<W,T>(src);

        [MethodImpl(Inline)]
        public DataCells<W,T> Refresh(DataCell<W,T>[] src)
            => src;

        public ref DataCell<W,T> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public uint Count
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
            get => (Count* CellWidth)/8;
        }

        public ulong DataWidth
        {
            [MethodImpl(Inline)]
            get => ((ulong)Count * (ulong)CellWidth);
        }

        public DataCell<W,T>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }
    }
}