//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    /// <summary>
    /// Defines a logical server
    /// </summary>
    public class ServerAgent : SystemAgent
    {        
        public static ServerAgent Define(AgentContext Context, ServerConfig Config)
            => new ServerAgent(Context, Config);

        ServerConfig Config {get;}

        ServerProcess Worker {get; }

        ServerAgent(AgentContext Context, ServerConfig Config)
            : base(Context, (Config.ServerId, 0u))
        {
            this.Config = Config;
            var hearbeat = PulseEmitter.Define(Context, 
                ServiceIdentityPool.NextAgentId(ServerId), 
                new PulseEmitterConfig(new TimeSpan(0,0,1)));            
            this.Worker = ServerProcess.Define(Context, ServerId, Config.CoreNumber, new ISystemAgent[]{hearbeat});
        }

        protected override async void OnStart()
        {
            await Worker.Start();
        }

        protected override async void OnStop()
        {
            await Worker.Stop();
        }
    }
}