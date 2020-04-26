//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct CaptureServiceProxy : ICaptureServiceProxy
    {
        public ICaptureExchange CaptureExchange {get;}

        public ICaptureService CaptureService {get;}

        [MethodImpl(Inline)]
        public static ICaptureServiceProxy Create(ICaptureService service, ICaptureExchange exchange)
            => new CaptureServiceProxy(service, exchange);

        [MethodImpl(Inline)]
        public CaptureServiceProxy(ICaptureService service, ICaptureExchange exchange)
        {
            CaptureService = service;
            CaptureExchange = exchange;
        }
    }
}