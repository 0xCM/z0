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

    partial struct Cmd
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdLogger logger<T>(IWfShell wf, T id)
            where T : unmanaged
                => logger(wf, id.ToString());

        [MethodImpl(Inline), Op]
        public static CmdLogger logger(IWfShell wf, string name)
            => new CmdLogger(wf, wf.Paths.AppDataDir + FS.file(name, ArchiveFileKinds.StatusLog));

        [MethodImpl(Inline), Op]
        public static CmdHandler handler(CmdId id, Func<CmdSpec,CmdResult> fx)
            => new CmdHandler(id,fx);
    }
}