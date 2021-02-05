//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct SFx
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BoxedValueMap<T> convert<T>(Func<object,T> f)
            where T : struct
                => convert(f, alloc<T>(1));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BoxedValueMap<T> convert<T>(Func<ValueType,T> f)
            where T : struct
                => convert(f, alloc<T>(1));

        [MethodImpl(Inline)]
        public static ValueMap<S,T> convert<S,T>(Func<S,T> f)
            where S : struct
            where T : struct
                => convert(f, alloc<T>(1));

        [MethodImpl(Inline), Op, Closures(Closure)]
        static BoxedValueMap<T> convert<T>(Func<object,T> f, T[] dst)
            where T : struct
                => boxed(f, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        static BoxedValueMap<T> convert<T>(Func<ValueType,T> f, T[] dst)
            where T : struct
                => new ProjectorProxy<T>(x => f((ValueType)x), dst);

        [MethodImpl(Inline)]
        static ValueMap<S,T> convert<S,T>(Func<S,T> f, T[] dst)
            where S : struct
            where T : struct
                => new ProjectorProxy<S,T>(f, dst);
    }
}