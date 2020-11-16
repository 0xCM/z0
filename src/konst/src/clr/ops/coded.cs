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

    partial struct ClrQuery
    {
        [MethodImpl(Inline), Op]
        public static ref readonly Type coded(in ClrTypeCodes src, TypeCode tc)
            => ref src[tc];

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Type coded<T>(in ClrTypeCodes src)
            => src.type_u<T>();
    }
}