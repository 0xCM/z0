//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static WfEvents;

    partial interface IWfShell
    {
        WfExecFlow<FS.FilePath> EmittingFile(FS.FilePath dst)
        {
            signal(this).EmittingFile(dst);
            return Flow(dst);
        }

        WfExecToken EmittedFile(WfExecFlow<FS.FilePath> flow, Count count = default)
        {
            signal(this).EmittedFile(count, flow.Data);
            return Ran(flow);
        }
    }
}