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

    public sealed class CmdDispatch
    {
        readonly CmdHost Host;

        readonly ConcurrentDictionary<CmdId,CmdHandler> Handlers;

        public CmdDispatch()
        {
            Handlers = new ConcurrentDictionary<CmdId, CmdHandler>();
            Host = new CmdHost();
        }

        public Outcome<CmdResult> Run(IWfShell wf, CmdSpec spec)
        {
            try
            {
                return Execute(wf, spec);
            }
            catch(Exception e)
            {
                wf.Error(Host, e);
                return e;
            }
        }

        CmdResult Execute(IWfShell wf, CmdSpec spec)
        {
            if(Handlers.TryGetValue(spec.Id, out var handler))
            {
                try
                {
                    return handler.Exec(spec);
                }
                catch(Exception e)
                {
                    wf.Error(e);
                    return CmdResult.Empty;
                }
            }
            else return CmdResult.Empty;
        }

        [MethodImpl(Inline)]
        public bool Register(in CmdHandler handler)
            => Handlers.TryAdd(handler.Id, handler);
    }
}