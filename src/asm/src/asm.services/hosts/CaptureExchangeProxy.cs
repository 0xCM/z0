//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CaptureExchangeProxy : ICaptureExchange
    {
        /// <summary>
        /// The juncture-coincident operation set
        /// </summary>
        public ICaptureCore Service {get;}

        /// <summary>
        /// The buffer that receives the captured data
        /// </summary>
        public BufferToken TargetBuffer {get;}

        [MethodImpl(Inline)]
        internal CaptureExchangeProxy(ICaptureCore service, BufferToken target)
        {
            TargetBuffer = target;
            Service = service;
        }
    }
}