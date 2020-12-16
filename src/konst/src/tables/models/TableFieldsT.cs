//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;

    public readonly struct TableFields<F>
        where F : unmanaged
    {
        public TableSpan<TableField<F>> Table {get;}

        [MethodImpl(Inline)]
        public static implicit operator TableFields<F>(TableField<F>[] src)
            => new TableFields<F>(src);

        [MethodImpl(Inline)]
        public TableFields(TableField<F>[] src)
            => Table = src;

        public Count Count
        {
            [MethodImpl(Inline)]
            get => Table.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Table.Length;
        }

        public ReadOnlySpan<TableField<F>> View
        {
            [MethodImpl(Inline)]
            get => Table.View;
        }

        public TableField<F> this[F id]
        {
            [MethodImpl(Inline)]
            get => Table.Where(x => x.Id.ToString() == id.ToString()).Storage.Single();
        }

        public TableField<F> this[string name]
        {
            [MethodImpl(Inline)]
            get => Table.Where(x => x.Id.ToString() == name).Storage.Single();
        }

        public ref TableField<F> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Table[index];
        }

        [MethodImpl(Inline)]
        public string Name(uint index)
            => this[index].Name;
    }
}