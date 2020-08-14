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

    partial struct LiteralFieldApi
    {
        [MethodImpl(Inline), Op]
        public static object value(FieldInfo src)
            => sys.constant(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T value<T>(FieldInfo f)
            => sys.constant<T>(f);
    }
}