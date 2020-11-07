//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    public sealed class CmdRouter : ICmdRouter<CmdRouter>
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly CmdWorkers Workers;

        public IndexedView<CmdId> SupportedCommands
            => Workers.Keys.Array();

        internal CmdRouter(IWfShell wf, params ICmdWorker[] workers)
        {
            Host = WfSelfHost.create();
            Wf = wf.WithHost(Host);
            Workers = CmdWorkers.create();
            Enlist(workers);
        }

        public void Enlist(params ICmdWorker[] src)
            => iter(src,cmd => Workers.TryAdd(cmd.CmdId, cmd));

        public CmdResult Dispatch(CmdSpec cmd)
        {
            try
            {
                if(Workers.TryGetValue(cmd.Id, out var handler))
                    return handler.Invoke(Wf,cmd);
                else
                {
                    Wf.Error(WfEvents.missing(cmd.Id));
                    return Cmd.fail(cmd.Id);
                }
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return Cmd.fail(cmd.Id);
            }
        }
    }
}