//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    public readonly struct PartResolver
    {
        public static PartResolver Service => default;

        /// <summary>
        /// Attempts to resolve a part from an assembly file path
        /// </summary>
        public Option<IPart> Resolve(FilePath src)
            => from component in LoadAssembly(src)
                from type in resolve(component)
                from prop in resolve(type)
                from part in resolve(prop)
                select part;        

        public IPart[] Resolve(FilePath[] paths)
            => paths.Select(Resolve).Where(x => x.IsSome()).Select(x => x.Value);

        public bool IsPart(Assembly src)
            => test(src);

        public Assembly[] Parts(FilePath[] src)
            => src.Map(LoadAssembly).Where(x => x.IsSome()).Select(x => x.Value).Where(IsPart);

        public bool DefinesPart(FilePath src)
            => LoadAssembly(src).MapValueOrDefault(x => test(x));

        static bool test(Assembly src)
            => src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).Count() > 0;

        /// <summary>
        /// Loads an assembly from a potential part path
        /// </summary>
        static Option<Assembly> LoadAssembly(FilePath src)
            => Option.Try(src, x => Assembly.LoadFrom(x.FullPath));

        /// <summary>
        /// Attempts to resolve a part resolution type
        /// </summary>
        static Option<Type> resolve(Assembly src)
            => src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).FirstOrDefault();

        /// <summary>
        /// Attempts to resolve a part resolution property
        /// </summary>
        static Option<PropertyInfo> resolve(Type src)
            => src.StaticProperties().Where(p => p.Name == "Resolved").FirstOrDefault();

        /// <summary>
        /// Attempts to resolve a part from a resolution property
        /// </summary>
        static Option<IPart> resolve(PropertyInfo src)
            => Option.Try(src, x => (IPart)x.GetValue(null));
    }
}