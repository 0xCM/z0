//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Defines a logical server
    /// </summary>
    public class ServerAgent : SystemAgent
    {        
        public static ServerAgent create(AgentContext context, ServerConfig config)
            => new ServerAgent(context, config);

        ServerConfig Config {get;}

        ServerProcess Worker {get; }

        ServerAgent(AgentContext Context, ServerConfig Config)
            : base(Context, (Config.ServerId, 0u))
        {
            this.Config = Config;
            var hearbeat = PulseEmitter.define(Context, 
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