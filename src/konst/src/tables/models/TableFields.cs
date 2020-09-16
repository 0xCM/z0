//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct TableFields : ITableSpan<TableField>
    {
        readonly TableSpan<TableField> Data;

        [MethodImpl(Inline)]
        public static implicit operator TableFields(TableField[] src)
            => new TableFields(src);

        [MethodImpl(Inline)]
        public TableFields(TableField[] src)
            => Data = src;

        public Count Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref TableField this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref TableField this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public Option<TableField> this[string name]
        {
            [MethodImpl(Inline)]
            get
            {
                for(var i=0u; i<Count; i++)
                {
                    ref readonly var current = ref this[i];
                    if(current.Name == name)
                        return current;
                }
                return none<TableField>();
            }
        }

        public Option<TableField> this[in string name]
        {
            [MethodImpl(Inline)]
            get
            {
                for(var i=0u; i<Count; i++)
                {
                    ref readonly var current = ref this[i];
                    if(current.Name == name)
                        return current;
                }
                return none<TableField>();
            }
        }

        public ReadOnlySpan<TableField> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<TableField> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public TableField[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public static TableFields Empty
            => new TableFields(sys.empty<TableField>());
    }
}