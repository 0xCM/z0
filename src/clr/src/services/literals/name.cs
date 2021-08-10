//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    partial struct ClrLiterals
    {
        [MethodImpl(Inline), Op]
        public static StringAddress name(FieldInfo src)
            => text.address(src.Name);

        [MethodImpl(Inline), Op]
        public static StringAddress name(Type src)
            => text.address(src.Name);

        [MethodImpl(Inline), Op]
        public static StringAddress name(PropertyInfo src)
            => text.address(src.Name);

        [MethodImpl(Inline), Op]
        public static StringAddress name(MethodBase src)
            => text.address(src.Name);
    }
}