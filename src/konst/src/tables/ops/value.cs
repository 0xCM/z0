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
        public static RowValue value(byte[] src)
            => new RowValue(src);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static RowValue<T> value<T>(T src)
            where T : struct
                => new RowValue<T>(src);

        [MethodImpl(Inline), Op]
        public static object value(FieldInfo def, TypedReference tr)
            => def.GetValueDirect(tr);
    }
}