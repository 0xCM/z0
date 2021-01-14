//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface ICaptureExchange
    {
        /// <summary>
        /// The capture service in use
        /// </summary>
        ICaptureCore Service {get;}

        /// <summary>
        /// The buffer that receives the captured data
        /// </summary>
        BufferToken TargetBuffer {get;}

        CaptureExchange Context
        {
            [MethodImpl(Inline)]
            get => new CaptureExchange(Service, Buffers.cover(TargetBuffer));
        }
    }
}