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

    public sealed class WfServices
    {

        IWfShell Wf {get;}

        ConcurrentDictionary<Type,IWfService> Models {get;}

        public ApiServices ApiServices {get;}

        internal WfServices(IWfShell wf, Assembly[] components)
        {
            Wf = wf;
            Models = new ConcurrentDictionary<Type, IWfService>();
            var hosts = components.Types().Realize<IWfService>().Concrete().Select(x => (IWfService)Activator.CreateInstance(x));
            root.iter(hosts, host => Models.TryAdd(host.ContractType, host));
            ApiServices = Z0.ApiServices.create(Wf);
        }
    }
}