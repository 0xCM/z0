//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface ICaptureExchange
    {
        /// <summary>
        /// The capture service in use
        /// </summary>
        ICaptureCore Service {get;}

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
            get => CaptureExchange.Create(Service, TargetBuffer.Content<byte>(), StateBuffer.Content<byte>());
        }
    }
}