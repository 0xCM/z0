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
        WfTableFlow<T> EmittingTable<T>(FS.FilePath dst)
            where T : struct, IRecord<T>
        {
            signal(this).EmittingTable<T>(dst);
            return TableFlow<T>(dst);
        }

        WfExecToken EmittedTable<T>(WfTableFlow<T> flow, Count count, FS.FilePath? dst = null)
            where T : struct, IRecord<T>
        {
            signal(this).EmittedTable<T>(count, flow.Target);
            return Ran(flow);
        }
    }
}