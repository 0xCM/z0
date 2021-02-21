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

        WfExecFlow EmittingFile(FS.FilePath dst)
        {
            signal(this).EmittingFile(dst);
            return Flow();
        }

        WfExecToken EmittedFile(WfExecFlow flow, FS.FilePath dst)
        {
            signal(this).EmittedFile(dst);
            return Ran(flow);
        }

        void EmittedFile(Count count, FS.FilePath dst)
        {
            signal(this).EmittedFile(count, dst);
        }

        WfExecToken EmittedFile(WfExecFlow flow, Count count, FS.FilePath dst)
        {
            signal(this).EmittedFile(count, dst);
            return Ran(flow);
        }

        WfExecToken EmittedFile(WfExecFlow<FS.FilePath> flow, Count count)
        {
            signal(this).EmittedFile(count, flow.Data);
            return Ran(flow);
        }
    }
}