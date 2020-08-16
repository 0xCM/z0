//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IWfCaptureService : IDisposable
    {
        IWfCaptureBroker Broker {get;}

        ICaptureContext Context {get;}
    }
}