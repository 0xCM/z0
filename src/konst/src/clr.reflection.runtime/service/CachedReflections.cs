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

    public readonly struct CachedReflections
    {
        static readonly ConcurrentDictionary<Type, FieldInfo[]> Fields
            = new ConcurrentDictionary<Type, FieldInfo[]>();

        static readonly ConcurrentDictionary<Type, DataMember[]> DataMembers
            = new ConcurrentDictionary<Type, DataMember[]>();

        [MethodImpl(Inline)]
        public static FieldInfo[] Lookup(Type t, Func<Type, FieldInfo[]> f)
            => Fields.GetOrAdd(t,f);

        [MethodImpl(Inline)]
        public static IReadOnlyList<FieldInfo> Lookup(object o)
            => o == null ? sys.empty<FieldInfo>() : Lookup(o.GetType(), t => t.GetFields(BF_PublicInstance));


        [MethodImpl(Inline)]
        public static DataMember[] Lookup(Type t, Func<Type, DataMember[]> f)
            => DataMembers.GetOrAdd(t,f);

        static DataMember[] AutoProps(Type t)
        {
            var query = from f in t.Fields().NonPublic().Where(f => f.IsInitOnly)
                        where f.IsCompilerGenerated() && f.Name.EndsWith("__BackingField")
                        select f;
            var backingFields = query.ToSet();

            var properties = t.Properties().Instance().Select(x => (x.Name, x)).ToDictionary();

            var candidates = properties.Keys.Map(x =>
                    (prop: properties[x], Name:  $"\u003C{x}\u003Ek__BackingField"));
            var autoprops = z.list<DataMember>();
            foreach (var candidate in candidates)
            {
                backingFields.TryGetFirst(f => f.Name == candidate.Name)
                            .OnSome(f => autoprops.Add(new DataMember(candidate.prop, f)));
            }
            return autoprops.ToArray();
        }

        /// <summary>
        /// Gets the members of a type that can contain/represent data (properties and fields)
        /// </summary>
        /// <param name="src"></param>
        public static DataMember[] Lookup(Type src)
            => DataMembers.GetOrAdd(src, t =>
            {
                var members = z.list<DataMember>();

                members.AddRange(AutoProps(src));

                var fields = t.Fields().Instance().Select(x => new DataMember(x));
                members.AddRange(fields);
                var properties = t.Properties().Instance().Where(x => x.CanRead && x.CanWrite).Select(x => new DataMember(x));
                members.AddRange(properties);

                return members.ToArray();
            });
    }
}