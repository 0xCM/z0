//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Cmd
    {
        [Op]
        public static ICmdRouter router(IWfShell wf, ICmdWorker[] workers)
            => new CmdRouter(wf, workers);

        public static ICmdRouter router(IWfShell wf)
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
    }
}