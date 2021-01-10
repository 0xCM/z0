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
        WfExecFlow EmittingTable(Type type, FS.FilePath dst)
        {
            signal(this).TableEmitting(type, dst);
            return Flow();
        }

        WfExecFlow EmittingTable<T>(FS.FilePath dst)
            where T : struct
        {
            signal(this).EmittingTable<T>(dst);
            return Flow();
        }

        void EmittedTable<T>(WfStepId step, Count count, FS.FilePath dst)
            where T : struct
        {
            signal(this).EmittedTable<T>(step, count, dst);
        }

        WfExecToken EmittedTable<T>(WfExecFlow flow, Count count, FS.FilePath dst)
            where T : struct
        {
            signal(this).EmittedTable<T>(count, dst);
            return Ran(flow);
        }

        void EmittedTable<T>(Count count, FS.FilePath dst)
            where T : struct
        {
            signal(this).EmittedTable<T>(count, dst);
        }

        void EmittedTable(Type type, Count count, FS.FilePath dst)
        {
            signal(this).EmittedTable(type,count,dst);
        }

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