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

    sealed class LocateImages : CmdReactor<LocateImagesCmd,FS.FilePath>
    {
        protected override FS.FilePath Run(LocateImagesCmd cmd)
            => react(Wf,cmd);

        static FS.FilePath react(IWfShell wf, LocateImagesCmd cmd)
        {
            ProcessEmitters.emit(ProcessExtractors.images(), cmd.Target);
            return cmd.Target;
        }
    }
}