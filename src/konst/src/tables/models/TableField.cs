//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct TableField : ITableField        
    {        
        public FieldInfo Definition {get;}

        public RenderWidth Width {get;}

        [MethodImpl(Inline)]
        public TableField(FieldInfo def, RenderWidth width)
        {
            Definition = def;
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