//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    public class CmdRouter : ICmdRouter<CmdRouter>
    {
        [Op]
        public static ICmdRouter create(IWfShell wf, ICmdWorker[] workers)
            => new CmdRouter(wf, workers);

        public static ICmdRouter create(IWfShell wf)
        {
            var methods = @readonly(wf.Controller.Component.Types().DeclaredStaticMethods().Tagged<CmdWorkerAttribute>());
            var count = methods.Length;
            wf.Status(DiscoveredWorkers.Apply(count));

            var workers = list<ICmdWorker>();
            for(var i=0; i<count; i++)
            {
                ref readonly var method = ref skip(methods,i);
                var parameters = method.Parameters();
                if(parameters.Length == 2)
                {
                    var cmdType = parameters[1].ParameterType;
                    if(cmdType.IsStruct() && cmdType.Reifies<ICmdSpec>() && parameters[1].ParameterType == typeof(IWfShell))
                    {
                        var dType = typeof(CmdWorkerFunction<>).GenericDefinition2().MakeGenericType(cmdType);
                        var adapterType = typeof(CmdWorker<>).GenericDefinition2().MakeGenericType(cmdType);
                        var @delegate = method.CreateDelegate(dType);
                        var adapter = (ICmdWorker)Activator.CreateInstance(adapterType, @delegate);
                        workers.Add(adapter);

                    }
                    else
                        wf.Warn(WorkerWithWrongParameterTypes.Apply(method.Name));
                }
                else
                    wf.Warn(WorkerWithWrongParameterCount.Apply(method.Name));
            }

            return new CmdRouter(wf,workers.ToArray());
        }

        static RenderPattern<int> DiscoveredWorkers => "Discovered {0} workers";

        static RenderPattern<string> WorkerWithWrongParameterCount => "The methods {0} claimns to be a worker and yet does not have the required number of parameters";

        static RenderPattern<string> WorkerWithWrongParameterTypes => "The methods {0} claimns to be a worker and yet does not have the required parameter types";

        WfHost Host;

        IWfShell Wf;

        CmdWorkers Workers;

        public IndexedView<CmdId> SupportedCommands
            => Workers.Keys.Array();

        public CmdRouter()
        {

        }

        internal CmdRouter(IWfShell wf, params ICmdWorker[] workers)
        {
            Host = WfSelfHost.create();
            Wf = wf.WithHost(Host);
            Workers = CmdWorkers.create();
            Enlist(workers);
        }


        public void Enlist(params ICmdWorker[] src)
            => iter(src,cmd => Workers.TryAdd(cmd.CmdId, cmd));

        public CmdResult Dispatch(CmdSpec cmd)
        {
            try
            {
                if(Workers.TryGetValue(cmd.Id, out var handler))
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

        public void Init(IWfShell wf)
        {
            Host = WfSelfHost.create();
            Wf = wf.WithHost(Host);
            Workers = CmdWorkers.create();
        }
    }
}