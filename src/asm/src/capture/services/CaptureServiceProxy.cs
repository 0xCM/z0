//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CaptureServiceProxy : ICaptureServiceProxy
    {
        public ICaptureExchange CaptureExchange {get;}

        public ICaptureCore CaptureService {get;}

        [MethodImpl(Inline)]
        public CaptureServiceProxy(ICaptureCore service, ICaptureExchange exchange)
        {
            CaptureService = service;
            CaptureExchange = exchange;
        }
    }
}