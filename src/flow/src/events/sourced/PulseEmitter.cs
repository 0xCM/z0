//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Timers;

    /// <summary>
    /// Produces a periodic pulse event
    /// </summary>
    public class PulseEmitter : EventEmitter<PulseEvent>
    {        
        public static PulseEmitter define(AgentContext context, AgentIdentity identity, PulseEmitterConfig config)  
            => new PulseEmitter(context, identity, config);

        PulseEmitter(AgentContext context, AgentIdentity identity, PulseEmitterConfig config)  
            : base(context,identity)      
        {
            Timer = new Timer(config.Frequency.TotalMilliseconds);
            Timer.AutoReset = true;
            Timer.Elapsed += OnPulse;
        }
        
        void OnPulse(object sender, ElapsedEventArgs args)
            => Context.EventLog.Receive(PulseEvent.Define(ServerId, AgentId, ServerTimestamp.Timestamp()));      

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