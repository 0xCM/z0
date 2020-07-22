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

    public readonly struct FieldCache
    {
        static readonly ConcurrentDictionary<Type, FieldInfo[]> Index
            = new ConcurrentDictionary<Type, FieldInfo[]>();

        [MethodImpl(Inline)]
        public static FieldInfo[] Lookup(Type t, Func<Type, FieldInfo[]> f)
            => Index.GetOrAdd(t,f);

        [MethodImpl(Inline)]
        public static IReadOnlyList<FieldInfo> Lookup(object o)
            => o == null ? sys.empty<FieldInfo>() : Lookup(o.GetType(), t => t.GetFields(BF_PublicInstance));
    }
}