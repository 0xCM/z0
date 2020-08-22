//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    using static ReflectionFlags;
    using static Konst;

    public readonly struct MemberPropertyCache
    {
        static ConcurrentDictionary<Type, PropertyInfo[]> Index
            = new ConcurrentDictionary<Type, PropertyInfo[]>();

        [MethodImpl(Inline)]
        public static PropertyInfo[] Lookup(Type t, Func<Type, PropertyInfo[]> f)
            => Index.GetOrAdd(t,f);

        [MethodImpl(Inline)]
        public static IReadOnlyList<PropertyInfo> Lookup(object o)
            => o == null ? sys.empty<PropertyInfo>() : Lookup(o.GetType(), t => t.GetProperties(BF_PublicInstance));
    }
}