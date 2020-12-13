//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    readonly struct Msg
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static RenderPattern<T,ClosedInterval<T>> NotIn<T>()
            where T : unmanaged
                => "not({0} in {1})";

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static RenderPattern<T,T> NotEqual<T>()
            where T : unmanaged
                => "not({0}=={1})";

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static RenderPattern<T,T> NotGreaterThan<T>()
            where T : unmanaged
                => "not({0}>{1})";

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static RenderPattern<T,T> NotLessThan<T>()
            where T : unmanaged
                => "not({0}<{1})";

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static RenderPattern<T,T> NotGreaterThanOrEqual<T>()
            where T : unmanaged
                => "not({0}>={1})";

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static RenderPattern<T,T> NotLessThanOrEqual<T>()
            where T : unmanaged
                => "not({0}<={1})";
    }
}