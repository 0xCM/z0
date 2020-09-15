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

        [Op]
        public static ApiModules modules()
            => modules(Assembly.GetEntryAssembly(), Environment.GetCommandLineArgs());

        [MethodImpl(Inline)]
        public static ApiModules modules(Assembly control)
            => modules(control, Environment.GetCommandLineArgs());

        [Op]
        public static ApiModules modules(Assembly control, string[] args)
        {
            var parts = PartIdParser.parse(args);
            if(parts.Length != 0)
               return new ApiModules(control, parts);
            else
                return new ApiModules(control);
        }

        [Op]
        public static ApiModules modules(FS.FolderPath src)
            => new ApiModules(src);
    }
}