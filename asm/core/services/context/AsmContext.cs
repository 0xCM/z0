//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;

    public class AsmContext : IAsmContext 
    {            
        /// <summary>
        /// Creates a base context with a specified composition
        /// </summary>
        /// <param name="assemblies">A composition of assemblies to share with the context</param>
        [MethodImpl(Inline)]
        public static IAsmContext Create(IApiComposition assemblies, IAppSettings settings, IAppMsgExchange exchange,  IPolyrand random, AsmFormatConfig format)
            => new AsmContext(AsmContextData.Create(assemblies, settings, exchange, random, format));

        [MethodImpl(Inline)]
        protected AsmContext(AsmContextData state)
        {
            this.State = state;
            this.Next += BlackHole;
            this.State.Messaging.Next += Relay;            
        }            

        public AsmContextData State {get;}

        public event Action<AppMsg> Next;

        public IPolyrand Random => State.Random;

        IAppMsgExchange Messaging  => State.Messaging;
        
        public IAppSettings Settings  => State.Settings;

        public AsmFormatConfig AsmFormat  => State.AsmFormat;
        
        public IApiComposition Compostion => State.Assemblies;

        public IAsmContext WithFormat(AsmFormatConfig config)
            => new AsmContext(State);

        void BlackHole(AppMsg msg) {}

        void Relay(AppMsg msg)
            => Next(msg);
              
        public void Notify(AppMsg msg)
            => Messaging.Notify(msg);

        public void Notify(string msg, AppMsgKind? severity = null)
            => Messaging.Notify(msg, severity);

        public IReadOnlyList<AppMsg> Dequeue()
            => Messaging.Dequeue();

        public IReadOnlyList<AppMsg> Flush(Exception e)
            => Messaging.Flush(e);

        public void Emit(FilePath dst) 
            => Messaging.Emit(dst);
    }   
}