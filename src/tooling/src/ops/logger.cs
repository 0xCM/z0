//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct ToolCmd
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ToolCmdLogger logger<T>(IEnvPaths paths,  T id)
            where T : unmanaged
                => logger(paths, id.ToString());

        [MethodImpl(Inline), Op]
        public static ToolCmdLogger logger(IEnvPaths paths, string name)
            => new ToolCmdLogger(paths.CmdLogRoot() + FS.file(name, FS.StatusLog));
    }
}