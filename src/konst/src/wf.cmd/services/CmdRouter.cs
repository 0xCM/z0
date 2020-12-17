//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Konst;
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


        public CmdResult<T> Dispatch<S,T>(S src)
            where S : struct, ICmdSpec<S>
            where T : struct
        {
            try
            {
                if(Nodes.TryGetValue(src.CmdId, out var node) && node is ICmdReactor<S,T> worker)
                {
                    var result = worker.Invoke(src);
                    if(result.Succeeded)
                        Wf.Error(result);
                    else
                        Wf.Status(result);

                    return result;
                }
                else
                {
                    Wf.Error(WfEvents.missing(src.CmdId));
                    return new CmdResult<T>(src.CmdId, false);
                }
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return new CmdResult<T>(src.CmdId, false);
            }
        }

        public CmdResult Dispatch(ICmdSpec cmd)
        {
            using var dispatch = Wf.Running(Msg.DispatchingCommand.Format(cmd.Format()));
            try
            {
                if(Nodes.TryGetValue(cmd.CmdId, out var node))
                {
                    Wf.Status($"Dispatching {cmd.CmdId} to reactor {node.GetType().Name}");
                    var result = node.Invoke(cmd);
                    if(result.Succeeded)
                        Wf.Error(result);
                    else
                        Wf.Status(result);
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
}