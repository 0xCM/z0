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

    partial struct Cil
    {
        public class RuntimeIndex
        {
            public static RuntimeIndex create(Assembly assembly)
                => create(assembly.Modules.ToArray());

            public static RuntimeIndex create(params Module[] modules)
                => new RuntimeIndex(modules);

            ConcurrentDictionary<int,Type> TypeIndex
                = new ConcurrentDictionary<int,Type>();

            ConcurrentDictionary<int, MethodInfo> MethodIndex
                = new ConcurrentDictionary<int, MethodInfo>();

            internal RuntimeIndex(params Module[] modules)
            {
                root.iter(modules, Index);
            }

            public Option<Type> FindType(int id)
                => TypeIndex.TryFind(id);

            public Option<MethodInfo> FindMethod(int id)
                => MethodIndex.TryFind(id);

            public bool IsEmpty
                => MethodIndex.Count == 0;

            void Index(MethodInfo src)
            {
                z.insist(MethodIndex.TryAdd(src.MetadataToken, src), $"Attempt to include {src} in the index failed");
            }

            void Index(Type src)
            {
                z.insist(TypeIndex.TryAdd(src.MetadataToken, src), $"Attempt to include {src} in the index failed");
                root.iter(src.DeclaredMethods(), Index);
            }

            void Index(Module mod)
            {
                root.iter(mod.GetTypes(), Index);
            }
        }
    }
}