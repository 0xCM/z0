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
        [MethodImpl(Inline), Op]
        public static ClrStruct @struct(Type src)
            => new ClrStruct(src) ;


        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ClrStruct @struct<T>()
            where T : struct
                => new ClrStruct<T>(typeof(T));
    }
}