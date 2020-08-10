//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct TableField<F> : ITableField<F>
        where F : unmanaged, Enum
    {
        public F Id {get;}        
        
        public FieldInfo Definition {get;}

        public RenderWidth Width {get;}

        [MethodImpl(Inline)]
        public TableField(F id, FieldInfo def, RenderWidth width)
        {
            Definition = def;
            Id = id;
            Width = width;
        }                

        public string Name
        {
            [MethodImpl(Inline)]
            get => Definition.Name;
        }

        public Type DataType
        {
            [MethodImpl(Inline)]
            get => Definition.FieldType;
        }
    }
}