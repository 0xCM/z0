//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Konst;

    partial struct Flow
    {
        public static string AppName
        {
            [MethodImpl(Inline), Op]
            get => Assembly.GetEntryAssembly().GetSimpleName();
        }

        [MethodImpl(Inline), Op]
        public static IAppContext app()
            => ContextFactory.create();

        // {
        //     var paths = AppPaths.Default;
        //     var modules = ModuleArchives.from(paths.RuntimeRoot);
        //     return AppContext.create(paths,
        //         ApiPart.Assemble(modules),
        //         Polyrand.Pcg64(PolySeed64.Seed05));
        // }
    }
}