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

    public sealed class CmdExec : CmdExec<CmdExec, CmdSpec, CmdResult>
    {
        readonly ConcurrentDictionary<CmdId,CmdHandler> Handlers;

        public CmdExec()
        {
            Handlers = new ConcurrentDictionary<CmdId, CmdHandler>();
        }

        protected override CmdResult Execute(IWfShell wf, CmdSpec spec)
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