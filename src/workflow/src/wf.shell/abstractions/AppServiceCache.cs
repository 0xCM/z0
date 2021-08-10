//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public sealed class AppServiceCache : AppService<AppServiceCache>
    {
        Dictionary<Type,IAppService> Services;

        object locker;

        public AppServiceCache()
        {
            Services = new();
            locker = new object();
        }

        public T Service<T>()
            where T : IAppService, new()
        {
            var svc = default(IAppService);
            lock(locker)
            {
                var key = typeof(T);
                if(!Services.TryGetValue(key, out svc))
                {
                    svc = new T();
                    svc.Init(Wf);
                    Services[key] = svc;
                }
            }
            return (T)svc;
        }
    }
}