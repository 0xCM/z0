//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    
    using static Seed;

    public readonly struct CheckCapture : ICheckCapture
    {
        [MethodImpl(Inline)]
        public static ICheckCapture Create(ICaptureService service, ICaptureExchange exchange)
            => new CheckCapture(service, exchange);

        [MethodImpl(Inline)]
        public CheckCapture(ICaptureService service, ICaptureExchange exchange)
        {
            this.CaptureService = service;
            this.CaptureExchange = exchange;
        }

        public ICaptureExchange CaptureExchange {get;}

        public ICaptureService CaptureService {get;}
    }

    public interface ICheckCapture : ICaptureServiceProxy
    {

    }
}