//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableRows<T>
        where T : struct
    {
        readonly TableRow<T>[] Storage;

        [MethodImpl(Inline)]
        public static implicit operator TableRows<T>(TableRow<T>[] data)
            => new TableRows<T>(data);

        [MethodImpl(Inline)]
        public TableRows(TableRow<T>[] src)
            => Storage = src;

        public Span<TableRow<T>> Edit
        {
            [MethodImpl(Inline)]
            get => Storage;
        }

        public ref TableRow<T> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Storage[(int)index];
        }

        public ref TableRow<T> this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Storage[(int)index];
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Storage.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Storage.Length;
        }
    }
}