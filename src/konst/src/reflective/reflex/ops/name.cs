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
        public static string name(FieldInfo src)
            => src.Name;

        [MethodImpl(Inline), Op]
        public static string name(MethodInfo src)
            => src.Name;

        [MethodImpl(Inline), Op]
        public static string name(Type src)
            => src.Name;

        [MethodImpl(Inline), Op]
        public static string name(PropertyInfo src)
            => src.Name;
    }
}