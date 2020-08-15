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
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline), Op]
        public static TableField field(FieldInfo definition, RenderWidth? width = null)
            => new TableField(definition, width ?? new RenderWidth());

        [MethodImpl(Inline), Op]
        public static TableField<F> field<F,T>(F id, FieldInfo def, RenderWidth? width = null)
            where F : unmanaged, Enum
            where T : struct, ITable<F,T>
                => new TableField<F>(id,def, width ?? (new RenderWidth(@as<F,byte>(id))));
    }
}