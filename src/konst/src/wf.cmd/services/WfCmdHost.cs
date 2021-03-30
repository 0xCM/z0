//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    [WfCmdHost]
    public abstract class WfCmdHost<H,K> : WfService<H>, IWfCmdHost<K>
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

        public static Type CommandType => typeof(K);

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
                Wf.Babble(string.Format("Registered <{0}> commands from <{1}>", Index.Count, typeof(H).Name));
            }
        }

        protected virtual void RegisterCommands(WfCmdIndex index)
        {
            var count = GetType().DeclaredInstanceMethods().Tagged<ActionAttribute>(out var methods);
            if(count != 0)
            {
                var view = methods.View;
                for(var i=0; i<count; i++)
                {
                    ref readonly var method = ref skip(view,i);
                    index.Include(WfCmd.assign((K)method.Tag.Key, (Action)method.Method.CreateDelegate(typeof(Action),this)));
                }
            }
        }
    }
}