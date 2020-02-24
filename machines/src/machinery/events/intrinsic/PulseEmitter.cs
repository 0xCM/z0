//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Timers;

    using static zfunc;

    /// <summary>
    /// Produces a periodic pulse event
    /// </summary>
    public class PulseEmitter : EventEmitter<PulseEvent>
    {        
        public static PulseEmitter Define(AgentContext Context, AgentIdentity Identity, PulseEmitterConfig Config)  
        {
            return new PulseEmitter(Context, Identity, Config);
        }

        PulseEmitter(AgentContext Context, AgentIdentity Identity, PulseEmitterConfig Config)  
            : base(Context,Identity)      
        {
            this.Timer = new Timer(Config.Frequency.TotalMilliseconds);
            this.Timer.AutoReset = true;
            this.Timer.Elapsed += OnPulse;
        }
        
        void OnPulse(object sender, ElapsedEventArgs args)
        {
            Context.EventLog.Receive(PulseEvent.Define(ServerId, AgentId, ServerTimestamp.Timestamp()));      
        }

        Timer Timer {get;}
        
        protected override void OnStart()
        {
            Timer.Start();
        }
        
        protected override void OnStop()
        {
            Timer.Stop();
        }

        protected override void OnTerminate()
            => Timer.Dispose();
    }
}