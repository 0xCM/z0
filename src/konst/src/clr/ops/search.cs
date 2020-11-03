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
        [Op, Closures(Closure)]
        public static FieldInfo[] search<T>(Type src)
            => src.Fields().Where(f => f.FieldType == typeof(T));
    }
}