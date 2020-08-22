//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;


    public readonly struct CheckCapture : ICaptureChecker
    {
        public ICaptureExchange CaptureExchange {get;}

        public ICaptureCore CaptureService {get;}

        [MethodImpl(Inline)]
        public static ICaptureChecker Create(ICaptureCore service, ICaptureExchange exchange)
            => new CheckCapture(service, exchange);

        [MethodImpl(Inline)]
        public CheckCapture(ICaptureCore service, ICaptureExchange exchange)
        {
            CaptureService = service;
            CaptureExchange = exchange;
        }


    }
}