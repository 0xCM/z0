//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableField<F,T,V> : ITableField<F,T,V>
        where F : unmanaged, Enum
        where T : struct, ITable<T>
    {
        public StringRef FieldName {get;}

        public F FieldId {get;}

        public RenderWidth<ushort> RenderWidth {get;}

        [MethodImpl(Inline)]
        public TableField(F id, string name, ushort rw = default)
        {
            FieldId = id;
            RenderWidth = rw;
            FieldName = name;
        }

        public Address64 FieldOffset
        {
            [MethodImpl(Inline)]
            get => Interop.offset<T>(FieldName);
        }

        public Type DataType
        {
            [MethodImpl(Inline)]
            get => typeof(V);
        }
    }
}