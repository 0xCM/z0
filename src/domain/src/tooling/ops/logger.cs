//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Tooling
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ToolLogger logger<T>(IWfShell wf, T id)
            where T : unmanaged
                => logger(wf, id.ToString());

        [MethodImpl(Inline), Op]
        public static ToolLogger logger(IWfShell wf, string name)
            => new ToolLogger(wf, wf.Paths.AppDataDir + FS.file(name, ArchiveFileKinds.StatusLog));
    }
}