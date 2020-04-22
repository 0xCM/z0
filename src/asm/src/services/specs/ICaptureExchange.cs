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

    public interface ICaptureExchange
    {
        /// <summary>
        /// The juncture-coincident operation set 
        /// </summary>
        ICaptureService Service {get;}

        /// <summary>
        /// The junction to which events will be relayed
        /// </summary>
        ICaptureJunction Junction => Control;

        /// <summary>
        /// The capture control
        /// </summary>
        ICaptureControl Control {get;}

        /// <summary>
        /// The buffer that receives the captured data
        /// </summary>
        IBufferToken TargetBuffer {get;}
        
        /// <summary>
        /// A buffer that tracks state meaningful to the capture workflow
        /// </summary>
        IBufferToken StateBuffer {get;}

        CaptureExchange Context
        {
            [MethodImpl(Inline)]
            get => CaptureExchange.Create(Control, TargetBuffer.Content<byte>(), StateBuffer.Content<byte>());
        }
    }
}