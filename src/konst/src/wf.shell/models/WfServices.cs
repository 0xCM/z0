//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;
    using System.Reflection;

    public sealed class WfServices : IDisposable
    {
        IWfShell Wf {get;}

        ConcurrentDictionary<Type,IWfService> Models {get;}

        public ApiServices ApiServices {get;}

        public IWfEmissionLog EmissionLog {get;}

        public Env Env {get;}

        internal WfServices(IWfShell wf, Assembly[] components)
        {
            Wf = wf;
            Env = Z0.Env.create();
            Models = new ConcurrentDictionary<Type, IWfService>();
            var hosts = components.Types().Realize<IWfService>().Concrete().Select(x => (IWfService)Activator.CreateInstance(x));
            root.iter(hosts, host => Models.TryAdd(host.ContractType, host));
            ApiServices = Z0.ApiServices.create(Wf);
            EmissionLog = new WfEmissionLog(wf.Db().LogRoot());
        }

        public void Dispose()
        {
            EmissionLog?.Dispose();
        }
    }
}