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
        [MethodImpl(Inline)]
        public static TableField<F> field<F,T>(F id, FieldInfo def, ushort? width = null)
            where F : unmanaged, Enum
            where T : struct, ITable<F,T>
                => new TableField<F>(id,def, width ?? (new RenderWidth<ushort>(@as<F,ushort>(id))));
    }
}