//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Concurrent;

    partial class WfShell
    {
        [Op]
        public static ConcurrentDictionary<Type,IWfService> services(params Assembly[] src)
        {
            var services = src.Types().Realize<IWfService>().Concrete().Select(x => (IWfService)Activator.CreateInstance(x));
            var lookup = new ConcurrentDictionary<Type,IWfService>();
            root.iter(services, host => lookup.TryAdd(host.ContractType, host));
            return lookup;
        }
    }
}