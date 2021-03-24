//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Concurrent;

    public class RuntimeIndex
    {
        public static RuntimeIndex create(Assembly src)
            => create(src.Modules.ToArray());

        public static RuntimeIndex create(params Module[] src)
            => new RuntimeIndex(src);

        ConcurrentDictionary<int,Type> TypeIndex
            = new ConcurrentDictionary<int,Type>();

        ConcurrentDictionary<int, MethodInfo> MethodIndex
            = new ConcurrentDictionary<int, MethodInfo>();

        internal RuntimeIndex(params Module[] modules)
            => root.iter(modules, Index);

        public Option<Type> FindType(int id)
            => TypeIndex.TryFind(id);

        public Option<MethodInfo> FindMethod(int id)
            => MethodIndex.TryFind(id);

        public bool IsEmpty
            => MethodIndex.Count == 0;

        void Index(MethodInfo src)
            => MethodIndex.TryAdd(src.MetadataToken, src);

        void Index(Type src)
        {
            TypeIndex.TryAdd(src.MetadataToken, src);
            root.iter(src.DeclaredMethods(),Index);
        }

        void Index(Module mod)
        {
            root.iter(mod.GetTypes(), Index);
        }
    }
}