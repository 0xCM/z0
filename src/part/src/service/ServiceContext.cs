//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ServiceContext : IServiceContext
    {
        public IEventSink EventSink {get;}

        public EnvData Env {get;}

        public IAppPaths AppPaths
             => new AppPaths(Env.Db);

        public IEnvPaths EnvPaths
            => new EnvPaths(Env);

        [MethodImpl(Inline)]
        public ServiceContext(IEnvProvider env, IEventSink sink)
        {
            Env = env.Env;
            EventSink = sink;
        }

        [MethodImpl(Inline)]
        public ServiceContext(EnvData env, IEventSink sink)
        {
            Env = env;
            EventSink = sink;
        }

        [MethodImpl(Inline)]
        public static implicit operator ServiceContext((IEnvProvider env, IEventSink sink) src)
            => new ServiceContext(src.env, src.sink);
    }
}