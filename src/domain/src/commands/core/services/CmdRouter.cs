//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Concurrent;

    using static Konst;
    using static z;

    public sealed class CmdRouter : ICmdRouter<CmdRouter>
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly ConcurrentDictionary<CmdId,CmdHandler> Handlers;

        readonly ConcurrentDictionary<CmdId,ICmdRunner> Runners;

        internal CmdRouter(IWfShell wf, params CmdHandler[] handlers)
        {
            Host = WfSelfHost.create();
            Wf = wf.WithHost(Host);
            Handlers = new ConcurrentDictionary<CmdId, CmdHandler>();
            Enlist(handlers);

            var runners = CmdRunners.discover(Parts.Domain.Assembly);
            var lookup = new ConcurrentDictionary<CmdId,ICmdRunner>();
            iter(runners, r => lookup.TryAdd(r.CmdId, r));
            Runners = lookup;
        }

        public void Enlist(params CmdHandler[] src)
            => iter(src,cmd => Handlers.TryAdd(cmd.Id,cmd));

        public CmdResult Dispatch(CmdSpec cmd)
        {
            try
            {
                if(Runners.TryGetValue(cmd.Id, out var runner))
                {
                    return Cmd.win(cmd.Id);
                }
                else if(Handlers.TryGetValue(cmd.Id, out var handler))
                {
                    return handler.Exec(cmd);
                }
                else
                {
                    Wf.Error(WfErrors.missing(cmd.Id));
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