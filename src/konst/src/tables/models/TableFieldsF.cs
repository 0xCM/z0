//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Konst;   
    using static z;

    public readonly struct TableFields<F>
        where F : unmanaged, Enum
    {
        public TableField<F>[] Data {get;}
        
        [MethodImpl(Inline)]
        public static implicit operator TableFields<F>(TableField<F>[] src)
            => new TableFields<F>(src);

        [MethodImpl(Inline)]
        public static implicit operator TableFields(TableFields<F> src)
            => new TableFields(src.Data.Map(x => new TableField(x.Definition, x.Width)));
        
        [MethodImpl(Inline)]
        public TableFields(TableField<F>[] src)
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
        public TableField<F> this[F id]
        {
            [MethodImpl(Inline)]
            get => Data.Where(x => x.Id.ToString() == id.ToString()).Single();
        }

        public TableField<F> this[string name]
        {
            [MethodImpl(Inline)]
            get => Data.Where(x => x.Id.ToString() == name).Single();
        }

        public ref TableField<F> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        [MethodImpl(Inline)]
        public RenderWidth Width(F f)
            => this[f].Width;

        [MethodImpl(Inline)]
        public string Name(uint index)
            => this[index].Name;

    }
}