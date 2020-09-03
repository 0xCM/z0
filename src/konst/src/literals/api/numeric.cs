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

    using NBK = NumericBaseKind;

    partial struct Literals
    {
        [MethodImpl(Inline)]
        public static unsafe V numeric<E,V>(E e)
            where E : unmanaged, Enum
            where V : unmanaged
                => Unsafe.Read<V>((V*)(&e));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static NumericLiteral<T> numeric<T>(string Name, T data, string Text, NBK @base)
            where T : unmanaged
            => new NumericLiteral<T>(Name,data, Text, @base);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T numeric<T>(FieldInfo f)
            where T : unmanaged
                => sys.constant<T>(f);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] numeric<T>(Type src)
            where T : unmanaged
                => z.map(search<T>(src),numeric<T>);
    }
}