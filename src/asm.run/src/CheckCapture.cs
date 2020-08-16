//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public interface ICheckCapture : ICaptureServiceProxy
    {

    }

    public readonly struct CheckCapture : ICheckCapture
    {
        public ICaptureExchange CaptureExchange {get;}

        public ICaptureCore CaptureService {get;}        
        
        [MethodImpl(Inline)]
        public static ICheckCapture Create(ICaptureCore service, ICaptureExchange exchange)
            => new CheckCapture(service, exchange);

        [MethodImpl(Inline)]
        public CheckCapture(ICaptureCore service, ICaptureExchange exchange)
        {
            CaptureService = service;
            CaptureExchange = exchange;
        }

        
    }
}