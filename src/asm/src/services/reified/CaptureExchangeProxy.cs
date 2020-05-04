//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct CaptureExchangeProxy : ICaptureExchange
    {
        /// <summary>
        /// The juncture-coincident operation set 
        /// </summary>
        public ICaptureService Service {get;}

        /// <summary>
        /// The buffer that receives the captured data
        /// </summary>
        public IBufferToken TargetBuffer {get;}
        
        /// <summary>
        /// A buffer that tracks state meaningful to the capture workflow
        /// </summary>
        public IBufferToken StateBuffer {get;}

        [MethodImpl(Inline)]
        public static ICaptureExchange Create(ICaptureService service, IBufferToken capture, IBufferToken state)
            => new CaptureExchangeProxy(service,capture,state);
        
        [MethodImpl(Inline)]
        internal CaptureExchangeProxy(ICaptureService service, IBufferToken target, IBufferToken state)            
        {
            this.TargetBuffer = target;
            this.StateBuffer = state;
            this.Service = service;
        }
    }
}