//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Collections.Concurrent;

    using static Konst;
    using static z;

    public sealed class CmdRouter
    {
        readonly CmdHost Host;

        readonly IWfShell Wf;

        readonly ConcurrentDictionary<CmdId,CmdHandler> Handlers;

        public void Enlist(params CmdHandler[] src)
            => iter(src,cmd => Handlers.TryAdd(cmd.Id,cmd));

        public CmdRouter(IWfShell wf, params CmdHandler[] handlers)
        {
            Host = new CmdHost();
            Wf = wf.WithHost(Host);
            Handlers = new ConcurrentDictionary<CmdId, CmdHandler>();
            Enlist(handlers);
        }

        public Outcome<CmdResult> Dispatch(CmdSpec spec)
        {
            try
            {
                Wf.Running(spec.Id);

                if(Handlers.TryGetValue(spec.Id, out var handler))
                    return handler.Exec(spec);
                else
                {
                    var error = WfErrors.missing(spec.Id);
                    Wf.Error(error);
                    return default;
                }
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return e;
            }
            finally
            {
                Wf.Ran(spec.Id);
            }
        }
    }
}