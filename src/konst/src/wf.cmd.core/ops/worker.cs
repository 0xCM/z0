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
        [MethodImpl(Inline)]
        public static CmdWorker<C> worker<C>(CmdWorkerFunction<C> fx)
            where C : struct, ICmdSpec<C>
                => new CmdWorker<C>(fx);

        [MethodImpl(Inline), Op]
        public static CmdWorker worker(CmdId id, CmdWorkerFunction fx)
            => new CmdWorker(id, fx);

        [Op]
        public static CmdRouter router(IWfShell wf, Type host)
            => new CmdRouter(wf, workers(wf, host));

        // [Op]
        // public static CmdRouter router(IWfShell wf)
        //     => new CmdRouter(wf, workers(wf, typeof(Workers)));

        public static CmdWorkers workers<T>(IWfShell wf)
            where T : ICmdRouter<T>, new()
                => workers(wf, typeof(T));

        public static CmdWorkers workers(IWfShell wf, Type host)
        {
            var methods = @readonly(host.DeclaredInstanceMethods().Tagged<CmdWorkerAttribute>().WithArity(1));
            if(methods.Length == 0)
            {
                wf.Warn(DiscoveredWorkers.Apply(0, host.Name));
                return CmdWorkers.Empty;
            }
            else
            {
                wf.Status(DiscoveredWorkers.Apply(methods.Length, host.Name));
                var service = wf.Service(host);
                var count = (uint)methods.Length;
                var buffer = z.alloc<KeyedValue<CmdId,ICmdWorker>>(count);
                var dst = span(buffer);
                var dDef = typeof(CmdWorkerFunction<>).GenericDefinition2();
                var aDef = typeof(CmdWorker<>).GenericDefinition2();
                for(var i=0u; i<count; i++)
                {
                    ref readonly var method = ref skip(methods,i);
                    var parameter = method.Parameters()[0];
                    var cmdType = parameter.ParameterType;
                    var dType = dDef.MakeGenericType(cmdType);
                    var worker = method.CreateDelegate(dType, service);
                    var tAdapter = aDef.MakeGenericType(cmdType);
                    var id = Cmd.id(cmdType);
                    seek(dst,i) = (id, (ICmdWorker)Activator.CreateInstance(tAdapter, worker));
                    wf.Status(Enlisted.Apply(id));

                }

                return CmdWorkers.create(buffer);
            }
        }

        static RenderPattern<int,string> DiscoveredWorkers => "Discovered {0} {1} workers";

        static RenderPattern<CmdId> Enlisted => "Enlisted worker for {0}";

        static RenderPattern<string> WorkerWithWrongParameterTypes => "The methods {0} claimns to be a worker and yet does not have the required parameter types";
    }
}