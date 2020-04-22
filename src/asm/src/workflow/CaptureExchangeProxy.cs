//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct CaptureExchangeProxy : ICaptureExchange
    {
        [MethodImpl(Inline)]
        public static ICaptureExchange Create(ICaptureControl control, IBufferToken capture, IBufferToken state)
            => new CaptureExchangeProxy(control,capture,state);
        
        [MethodImpl(Inline)]
        CaptureExchangeProxy(ICaptureControl control, IBufferToken target, IBufferToken state)            
        {
            this.TargetBuffer = target;
            this.StateBuffer = state;
            this.Control = control;
            this.Service = control;
        }

        /// <summary>
        /// The juncture-coincident operation set 
        /// </summary>
        public ICaptureService Service {get;}

        /// <summary>
        /// The junction to which events will be relayed
        /// </summary>
        public ICaptureControl Control {get;}

        /// <summary>
        /// The buffer that receives the captured data
        /// </summary>
        public IBufferToken TargetBuffer {get;}
        
        /// <summary>
        /// A buffer that tracks state meaningful to the capture workflow
        /// </summary>
        public IBufferToken StateBuffer {get;}
    }
}