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
    using static Option;

    [ApiHost]
    public readonly struct Parted
    {
        /// <summary>
        /// Attempts to parse a part identifier; if unsuccessful, returns none
        /// </summary>
        /// <param name="name">The literal name</param>
        [MethodImpl(Inline), Op]
        public static PartId id(string name)
            => Enums.Parse(name, PartId.None);

        [MethodImpl(Inline), Op]
        public static string format(PartId src)
            => Part.format(src);

        [Op]
        public static string Format(TargetPart part)
            => text.concat(format(part.Source), PartConnector, format(part.Target));

        [MethodImpl(Inline), Op]
        public static TargetPart target(PartId src, PartId dst)
            => new TargetPart(src,dst);

        [MethodImpl(Inline), Op]
        public static bool contains(in PartIndex src, PartId id)
            => src.Data.ContainsKey(id);

        [MethodImpl(Inline), Op]
        public static Option<IPart> search(in PartIndex src, PartId id)
            => src.Data.TryGetValue(id, out var part) ? some(part) : none<IPart>();

        /// <summary>
        /// Creates an index over the known parts
        /// </summary>
        public static PartIndex executing()
            => index(ModuleArchives.executing().Parts);

        public static PartIndex index(Type src)
            => index(ModuleArchives.from(src).Parts);

        public static PartIndex index(IEnumerable<IPart> src)
        {
            var dst = new Dictionary<PartId,IPart>();
            foreach(var part in src)
                dst.TryAdd(part.Id, part);
            return new PartIndex(dst);
        }

        public static bool test(Assembly src)
            => src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).Count() > 0;

        public static Assembly[] parts(FilePath[] src)
            => src.Map(assembly).Where(x => x.IsSome()).Select(x => x.Value).Where(test);


        /// <summary>
        /// Attempts to resolve a part from an assembly file path
        /// </summary>
        public static Option<IPart> resolve(FilePath src)
            => from component in assembly(src)
                from type in resolve(component)
                from prop in resolve(type)
                from part in resolve(prop)
                select part;

        /// <summary>
        /// Attempts to resolve a part from an assembly file path
        /// </summary>
        public static Option<IPart> resolve(FS.FilePath src)
            => from component in assembly(FilePath.Define(src.Name))
                from type in resolve(component)
                from prop in resolve(type)
                from part in resolve(prop)
                select part;

        public static IPart[] resolve(FS.FilePath[] paths)
            => paths.Select(resolve).Where(x => x.IsSome()).Select(x => x.Value);

        public static IPart[] resolve(FilePath[] paths)
            => paths.Select(resolve).Where(x => x.IsSome()).Select(x => x.Value);

        /// <summary>
        /// Loads an assembly from a potential part path
        /// </summary>
        internal static Option<Assembly> assembly(FilePath src)
            => Option.Try(src, x => Assembly.LoadFrom(x.FullPath));

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
            => Option.Try(src, x => (IPart)x.GetValue(null));

        const string PartConnector = " -> ";
    }
}