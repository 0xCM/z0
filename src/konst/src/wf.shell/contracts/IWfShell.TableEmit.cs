//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

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

        WfExecToken EmittedTable<T>(WfExecFlow flow, FS.FilePath dst)
            where T : struct
        {
            signal(this).EmittedTable<T>(dst);
            return Ran(flow);
        }

        WfExecToken EmittedTable<T>(WfExecFlow flow, WfStepId step, Count count, FS.FilePath dst)
            where T : struct
        {
            signal(this).EmittedTable<T>(step, count, dst);
            return Ran(flow);
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

        WfExecToken EmittedTable(WfExecFlow flow, Type type, FS.FilePath dst)
        {
            signal(this).EmittedTable(type, dst);
            return Ran(flow);
        }
    }
}