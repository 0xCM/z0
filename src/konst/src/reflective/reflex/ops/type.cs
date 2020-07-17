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

    partial struct Reflex
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ClrType<T> type<T>()
            => new ClrType<T>(typeof(T));
        
        [MethodImpl(Inline), Op]
        public static Type[] nested(Type src)
            => src.GetNestedTypes();
    }
}