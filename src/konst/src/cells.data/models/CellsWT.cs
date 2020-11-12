//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Cells<W,T> : ITableSpan<Cells<W,T>, CellW<W,T>>
        where W : unmanaged, IDataWidth
        where T : struct, IDataCell
    {
        readonly TableSpan<CellW<W,T>> Data;

        [MethodImpl(Inline)]
        public Cells(CellW<W,T>[] data)
            => Data = data;

        public ref CellW<W,T> this[ulong index]
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

        public CellW<W,T>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public Cells<W,T> Refresh(CellW<W,T>[] src)
            => src;

        [MethodImpl(Inline)]
        public static implicit operator Cells<W,T>(CellW<W,T>[] src)
            => new Cells<W,T>(src);
    }
}