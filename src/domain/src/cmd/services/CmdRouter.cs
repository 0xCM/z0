//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Concurrent;

    using System.Reflection;
    using static Konst;
    using static z;

    public sealed class CmdRouter : ICmdRouter<CmdRouter>
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly ConcurrentDictionary<CmdId,CmdWorker> Handlers;

        internal CmdRouter(IWfShell wf, params CmdWorker[] handlers)
        {
            Host = WfSelfHost.create();
            Wf = wf.WithHost(Host);
            Handlers = new ConcurrentDictionary<CmdId, CmdWorker>();
            Enlist(handlers);
        }

        public void Enlist(params CmdWorker[] src)
            => iter(src,cmd => Handlers.TryAdd(cmd.CmdId, cmd));


        public CmdResult Dispatch(CmdSpec cmd)
        {
            try
            {
                if(Handlers.TryGetValue(cmd.Id, out var handler))
                    return handler.Invoke(Wf,cmd);
                else
                {
                    Wf.Error(WfEvents.missing(cmd.Id));
                    return Cmd.fail(cmd.Id);
                }
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return Cmd.fail(cmd.Id);
            }
        }

        public static CmdWorkers discover(IWfShell wf)
        {
            var nodes = @readonly(wf.Components);
            var count = nodes.Length;
            for(var i=0; i<count; i++)
                Visit(skip(nodes,i));
            return default;
        }

        static void Visit(Assembly src)
        {
            var nodes = @readonly(src.GetTypes());
            var count = nodes.Length;
            for(var i=0; i<count; i++)
                Visit(skip(nodes,i));
        }

        static void Visit(Type src)
        {
            var nodes = @readonly(src.StaticMethods());
            var count = nodes.Length;
            for(var i=0; i<count; i++)
                Visit(skip(nodes,i));
        }

        static void Visit(MethodInfo src)
        {
            if(src.Tagged<CmdWorkerAttribute>() && src.IsStatic)
            {
                var pTypes = src.ParameterTypes();
                if(pTypes.Length == 2 && pTypes[0].Reifies<IWfShell>())
                {
                    var cType = pTypes[1];
                    var dType = typeof(CmdWorkerFunction<>).MakeGenericType(cType);
                }
            }
        }
    }
}