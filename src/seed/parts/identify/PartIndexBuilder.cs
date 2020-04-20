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

    using static Seed;
    using static PartId;

    readonly struct PartIndexBuilder : IPartIndexBuilder
    {
        /// <summary>
        /// Creates the builkder, not the index
        /// </summary>
        public static IPartIndexBuilder Create()
            => default(PartIndexBuilder);

        /// <summary>
        /// Creates an index over the known parts
        /// </summary>
        public PartIndex Build()
            => PartIndex.Define(Known);
 
        /// <summary>
        /// The location of potentially knowable parts
        /// </summary>
        static FolderPath DefaultLocation 
            => FilePath.Define(Parts.Seed.Resolved.Owner.Location).FolderPath;

        /// <summary>
        /// External dependencies that don' participate in the componentization framework
        /// </summary>
        static IEnumerable<ExternId> External
            => type<ExternId>().LiteralValues<ExternId>().Where(x => x != 0);

        static IEnumerable<IPart> Known
            => resolve(paths());

        /// <summary>
        /// Loads an assembly from a potential part path
        /// </summary>
        static Option<Assembly> load(FilePath src)
            => Option.Try(src, x => Assembly.LoadFrom(x.FullPath));

        /// <summary>
        /// Attempts to resolve a part resolution type
        /// </summary>
        static Option<Type> resolve(Assembly src)
            => src.GetTypes().Where(t => t.Realizes<IPart>() && !t.IsAbstract).FirstOrDefault();

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

        /// <summary>
        /// Attempts to resolve a part from an assembly file path
        /// </summary>
        static Option<IPart> resolve(FilePath src)
            => from component in load(src)
                from type in resolve(component)
                from prop in resolve(type)
                from part in resolve(prop)
                select part;        

        static IEnumerable<FilePath> paths()
            => DefaultLocation.Files(FileExtensions.Dll)
                              .Include(nameof(Z0))                              
                              .Exclude(nameof(Test))
                              .Exclude(External.Select(x => x.Format()).ToArray());

        static IEnumerable<IPart> resolve(IEnumerable<FilePath> paths)
        {
            foreach(var path in paths)
            {
                var part = resolve(path);
                if(part.IsSome())
                    yield return part.Value;
            }
        } 
    }
}