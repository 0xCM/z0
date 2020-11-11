//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    public class CmdRouter : ICmdRouter<CmdRouter>
    {
        WfHost Host;

        IWfShell Wf;

        CmdWorkers Workers;

        public IndexedView<CmdId> SupportedCommands
            => Workers.Keys.Array();

        public void Init(IWfShell wf)
        {
            Host = WfSelfHost.create();
            Wf = wf.WithHost(Host);
            Workers = CmdWorkers.Empty;
        }

        public CmdRouter()
        {

        }

        internal CmdRouter(IWfShell wf, CmdWorkers workers)
        {
            Host = WfSelfHost.create();
            Wf = wf.WithHost(Host);
            Workers = workers;
        }

        public void Enlist(params ICmdWorker[] src)
            => iter(src,cmd => Workers.TryAdd(cmd.CmdId, cmd));

        public CmdResult Dispatch(ICmdSpec cmd)
        {
            try
            {
                if(Workers.TryGetValue(cmd.CmdId, out var handler))
                    return handler.Invoke(cmd);
                else
                {
                    Wf.Error(WfEvents.missing(cmd.CmdId));
                    return Cmd.fail(cmd.CmdId);
                }
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return Cmd.fail(cmd.CmdId);
            }
        }
    }
}