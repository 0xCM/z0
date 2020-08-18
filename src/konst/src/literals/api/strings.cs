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

    partial struct Literals
    {
        [MethodImpl(Inline), Op]
        public static FieldInfo[] strings(Type src)
        {
            var fields = src.DeclaredFields();
            return search(src).Where(f => f.IsStringLiteral());
        }

    }
}