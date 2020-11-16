//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableRows<T> : IIndex<TableRow<T>>
        where T : struct
    {
        readonly TableRow<T>[] Data;

        [MethodImpl(Inline)]
        public TableRows(TableRow<T>[] src)
            => Data = src;

        public TableRow<T>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<TableRow<T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref TableRow<T> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[(int)index];
        }

        public ref TableRow<T> this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[(int)index];
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        [MethodImpl(Inline)]
        public static implicit operator TableRows<T>(TableRow<T>[] data)
            => new TableRows<T>(data);

        public static TableRows<T> Empty
        {
            [MethodImpl(Inline)]
            get => sys.empty<TableRow<T>>();
        }
    }
}