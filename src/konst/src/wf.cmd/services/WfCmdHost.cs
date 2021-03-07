//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public abstract class WfCmdHost<H,K> : WfService<H, IWfCmdHost<K>>, IWfCmdHost<K>
        where H : WfCmdHost<H,K>, new()
        where K : unmanaged
    {
        static bool CommandsRegistered;

        public CmdResult Run(K kind)
        {
            if(WfCmd.find(kind, out var cmd))
                return Wf.Router.Dispatch(cmd.Enclosed);
            else
                return Cmd.fail(cmd.Enclosed);
        }

        protected WfCmdIndex Index;

        public IEnumerable<WfCmdExec> Hosted
            => Index.Values;

        protected override void Initialized()
        {
            Index = WfCmdIndex.create();
            if(!CommandsRegistered)
            {
                RegisterCommands(Index);
                CommandsRegistered = true;
            }
        }

        protected abstract void RegisterCommands(WfCmdIndex index);
    }
}