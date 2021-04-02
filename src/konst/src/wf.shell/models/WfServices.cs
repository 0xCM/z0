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

        ConcurrentDictionary<Type,IService> Lookup {get;}

        public IEmissionLogger EmissionLog {get;}

        public Env Env {get;}

        internal WfServices(IWfShell wf, Env env, Assembly[] components)
        {
            Wf = wf;
            Env = env;
            Lookup = new ConcurrentDictionary<Type, IService>();
            EmissionLog = new EmissonLogger(target(env));
        }


        public void Dispose()
        {
            EmissionLog?.Dispose();
        }

        static FS.FilePath target(Env env)
            => env.Logs.Value + FS.folder("emissions") + FS.file(env.AppId.Format() + ".emissions", FS.Extensions.Log);
    }
}