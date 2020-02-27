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

    public static class DataMember
    {
        [MethodImpl(Inline)]
        public static ReflectedField define(FieldInfo src)
            => new ReflectedField(src);

        [MethodImpl(Inline)]
        public static ReflectedProperty define(PropertyInfo src)
            => new ReflectedProperty(src);
    }
}