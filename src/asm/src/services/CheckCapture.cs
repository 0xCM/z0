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
        [MethodImpl(Inline)]
        public static ICheckCapture Create(ICaptureCore service, ICaptureExchange exchange)
            => new CheckCapture(service, exchange);

        [MethodImpl(Inline)]
        public CheckCapture(ICaptureCore service, ICaptureExchange exchange)
        {
            this.CaptureService = service;
            this.CaptureExchange = exchange;
        }

        public ICaptureExchange CaptureExchange {get;}

        public ICaptureCore CaptureService {get;}
    }
}