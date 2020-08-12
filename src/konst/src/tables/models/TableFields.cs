//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;

    public readonly struct TableFields        
    {        
        public TableField[] Data {get;}

        [MethodImpl(Inline)]
        public static implicit operator TableFields(TableField[] src)
            => new TableFields(src);

        [MethodImpl(Inline)]
        public TableFields(TableField[] src)
            => Data = src;

        public CellCount Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref TableField this[uint index]
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

        public ReadOnlySpan<TableField> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<TableField> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}