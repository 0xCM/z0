//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static WfEvents;

    partial interface IWfShell
    {
        IEmissionLogger Emissions
            => Services.EmissionLog;

        WfTableFlow<T> EmittingTable<T>(FS.FilePath dst)
            where T : struct, IRecord<T>
        {
            signal(this).EmittingTable<T>(dst);
            return Emissions.LogEmission(TableFlow<T>(dst));
        }

        WfExecToken EmittedTable<T>(WfTableFlow<T> flow, Count count, FS.FilePath? dst = null)
            where T : struct, IRecord<T>
        {
            var completed = Ran(flow);
            var counted = flow.WithCount(count).WithToken(completed);
            signal(this).EmittedTable<T>(count, counted.Target);
            Emissions.LogEmission(counted);
            return completed;
        }

        WfFileFlow EmittingFile(FS.FilePath dst)
        {
            signal(this).EmittingFile(dst);
            return Emissions.LogEmission(Flow(dst));
        }

        WfFileFlow EmittingFile<T>(FS.FilePath dst, T payload)
        {
            signal(this).EmittingFile(payload, dst);
            return Emissions.LogEmission(Flow(dst));
        }

        WfExecToken EmittedFile(WfFileFlow flow, Count count)
        {
            var completed = Ran(flow);
            var counted = flow.WithCount(count).WithToken(completed);
            signal(this).EmittedFile(count, counted.Target);
            Emissions.LogEmission(counted);
            return completed;
        }
    }
}