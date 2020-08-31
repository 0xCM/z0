//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    partial struct ApiQuery
    {
        public static IPart[] resolve(FS.Files paths)
            => resolve(paths.Data);

        /// <summary>
        /// Attempts to resolve a part from an assembly file path
        /// </summary>
        public static Option<IPart> resolve(FilePath src,
            [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int?  line = null)
                => from component in ApiQuery.assembly(src, caller, file, line)
                    from type in resolve(component)
                    from prop in resolve(type)
                    from part in resolve(prop)
                    select part;

        public static IPart[] resolve(FS.FilePath[] paths,
            [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int?  line = null)
                => paths.Select(p => resolve(p, caller, file, line)).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id);

        public static IPart[] resolve(FilePath[] paths,
            [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int?  line = null)
                => paths.Select(p => resolve(p, caller, file, line)).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id);

        /// <summary>
        /// Attempts to resolve a part from an assembly file path
        /// </summary>
        public static Option<IPart> resolve(FS.FilePath src,
            [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int?  line = null)
                => from component in ApiQuery.assembly(src)
                from type in resolve(component)
                from prop in resolve(type)
                from part in resolve(prop)
                select part;

        /// <summary>
        /// Attempts to resolve a part resolution type
        /// </summary>
        internal static Option<Type> resolve(Assembly src)
            => src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).FirstOrDefault();

        /// <summary>
        /// Attempts to resolve a part resolution property
        /// </summary>
        internal static Option<PropertyInfo> resolve(Type src)
            => src.StaticProperties().Where(p => p.Name == "Resolved").FirstOrDefault();

        /// <summary>
        /// Attempts to resolve a part from a resolution property
        /// </summary>
        internal static Option<IPart> resolve(PropertyInfo src)
            => Try(src, x => (IPart)x.GetValue(null));
    }
}