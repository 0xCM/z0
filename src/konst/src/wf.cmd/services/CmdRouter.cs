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

    public class CmdRouter : ICmdRouter<CmdRouter>
    {
        IWfShell Wf;

        ConcurrentDictionary<CmdId,ICmdReactor> Nodes;

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

        public CmdRouter()
        {

        }

        public void Init(IWfShell wf)
        {
            Wf = wf;
            Nodes = new ConcurrentDictionary<CmdId, ICmdReactor>();
        }

        public CmdRouter(IWfShell wf)
        {
            Wf =wf;
            Nodes = new ConcurrentDictionary<CmdId, ICmdReactor>();
        }

        public CmdResult<T> Dispatch<S,T>(S src)
            where S : struct, ICmdSpec<S>
            where T : struct
        {
            try
            {
                if(Nodes.TryGetValue(src.CmdId, out var node) && node is ICmdReactor<S,T> worker)
                    return worker.Invoke(src);
                else
                {
                    Wf.Error(WfEvents.missing(src.Id));
                    return new CmdResult<T>(src.Id, false);
                }
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return new CmdResult<T>(src.Id, false);
            }
        }

        public ReadOnlySpan<CmdResult<T>> Dispatch<S,T>(ReadOnlySpan<S> src, bool pll)
            where S : struct, ICmdSpec<S>
            where T : struct
        {
            var count = src.Length;
            var dst = span<CmdResult<T>>(count);
            if(pll)
            {
                @throw(missing());
            }
            else
            {
                for(var i=0; i<count; i++)
                    seek(dst,i) = Dispatch<S,T>(skip(src,i));
            }
            return dst;
        }

        public CmdResult Dispatch(ICmdSpec cmd)
        {
            Wf.Running(Msg.DispatchingCommand.Apply(cmd.Id));
            try
            {
                if(Nodes.TryGetValue(cmd.CmdId, out var node))
                {
                    return node.Invoke(cmd);
                }
                else
                {
                    Wf.Error(WfEvents.missing(cmd.Id));
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