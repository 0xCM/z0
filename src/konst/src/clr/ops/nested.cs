//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct ClrQuery
    {
        [MethodImpl(Inline), Op]
        public static Type[] nested(Type src)
            => src.GetNestedTypes();
    }
}