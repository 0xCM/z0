//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    [ApiHost]
    public readonly struct ClrTokens
    {
        [MethodImpl(Inline), Op]
        public static ClrToken from(Type src)
            => new ClrToken(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ClrToken from<T>()
            => new ClrToken(typeof(T));

        [MethodImpl(Inline), Op]
        public static ClrToken from(FieldInfo src)
            => new ClrToken(src);

        [MethodImpl(Inline), Op]
        public static ClrToken from(PropertyInfo src)
            => new ClrToken(src);

        [MethodImpl(Inline), Op]
        public static ClrToken from(MethodInfo src)
            => new ClrToken(src);

        [MethodImpl(Inline), Op]
        public static ClrToken from(ParameterInfo src)
            => new ClrToken(src);

        [MethodImpl(Inline), Op]
        public static ClrToken from(Assembly src)
            => new ClrToken(src);
    }
}