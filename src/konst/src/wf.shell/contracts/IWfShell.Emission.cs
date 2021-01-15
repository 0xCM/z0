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

        WfExecFlow EmittingFile<T>(T source, FS.FilePath dst)
        {
            signal(this).EmittingFile(source, dst);
            return Flow();
        }

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

        void EmittedFile<T>(T source, Count count, FS.FilePath dst)
        {
            signal(this).EmittedFile(source, count, dst);
        }

        WfExecToken EmittedFile<T>(WfExecFlow flow, T source, FS.FilePath dst)
        {
            signal(this).EmittedFile(source, dst);
            return Ran(flow);
        }

        void EmittedFile(Count count, FS.FilePath dst)
        {
            signal(this).EmittedFile(count, dst);
        }

        void EmittedFile(FS.FilePath dst)
        {
            signal(this).EmittedFile(dst);
        }

        WfExecToken EmittedFile(WfExecFlow flow, Count count, FS.FilePath dst)
        {
            signal(this).EmittedFile(count, dst);
            return Ran(flow);
        }
    }
}