//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Part;
    using static z;

    public sealed class CmdRouter : WfService<CmdRouter,ICmdRouter<CmdRouter>>, ICmdRouter<CmdRouter>
    {

        ConcurrentDictionary<CmdId,ICmdReactor> Nodes;

        public CmdRouter()
        {
            Nodes = new ConcurrentDictionary<CmdId,ICmdReactor>();
        }

        public CmdRouter(IWfShell wf)
            : base(wf)
        {
            Nodes = new ConcurrentDictionary<CmdId,ICmdReactor>();
        }

        protected override void OnInit()
        {

        }

        public IndexedView<CmdId> SupportedCommands
            => Nodes.Keys.Array();

        public void Enlist(params ICmdReactor[] src)
        {
            var count = 0;
            foreach(var reactor in src)
            {
                if(Nodes.TryAdd(reactor.CmdId, reactor))
                    count++;
            }
            iter(src, cmd => Nodes.TryAdd(cmd.CmdId, cmd));
        }

        public CmdResult Dispatch(ICmdSpec cmd)
        {
            using var dispatch = Wf.Running("Dispatching");
            try
            {
                if(Nodes.TryGetValue(cmd.CmdId, out var node))
                {

                    Wf.Status(Msg.DispatchingCmd.Format(cmd.CmdId, node.GetType().Name));
                    var result = node.Invoke(cmd);
                    if(result.Succeeded)
                        Wf.Status(result);
                    else
                        Wf.Error(result);
                    return result;
                }
                else
                {
                    Wf.Error(WfEvents.missing(cmd.CmdId));
                    return Cmd.fail(cmd);
                }
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return Cmd.fail(cmd, e);
            }
        }
    }

    partial struct Msg
    {
        public static RenderPattern<CmdId,string> DispatchingCmd => "Dispatching {0} command to {1}";
    }
}