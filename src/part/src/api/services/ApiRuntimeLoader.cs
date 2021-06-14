//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Root;
    using static core;

    public readonly partial struct ApiRuntimeLoader
    {
        public static FS.FilePath path(Assembly src)
            => FS.path(src.Location);

        public static FS.FolderPath dir(Assembly src)
            => path(src).FolderPath;

        [Op]
        internal static FS.Files managed(FS.FolderPath dir)
            => dir.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="FunctionalServiceAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        static Type[] svchosts(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<FunctionalServiceAttribute>());

        static bool TryLoadPart(Assembly src, out IPart dst)
        {
            var attempt = src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).Map(t => (IPart)Activator.CreateInstance(t)).ToArray();
            if(attempt.Length != 0)
            {
                dst = attempt.First();
                return true;
            }
            else
            {
                 dst = default;
                 return false;
            }
        }

        [Op]
        static Option<IPart> TryLoadPart(Assembly src)
        {
            if(TryLoadPart(src, out var dst))
                return Option.some(dst);
            else
                return Option.none<IPart>();
        }


        /// <summary>
        /// Loads an assembly from a potential part path
        /// </summary>
        [Op]
        static Option<Assembly> assembly(FS.FilePath src)
        {
            try
            {
                return Assembly.LoadFrom(src.Name);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return default;
            }
        }
    }
}