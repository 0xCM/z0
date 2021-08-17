//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public abstract class WsService<T> : Service<T>, IWsService<T>
        where T : WsService<T>,new()
    {
        protected WsService()
        {
            Dev = DevWs.create(Env.DevWs);
            Ws = Dev;
        }

        protected DevWs Dev;

        public IWorkspace Ws {get; private set;}

        public T WithWs(Identifier name)
        {
            if(Dev.Select(name, out var _ws))
            {
                Ws = _ws;
                Write(AppMsg.WorkspaceSelected.Format(name));
            }
            return (T)this;
        }
   }
}