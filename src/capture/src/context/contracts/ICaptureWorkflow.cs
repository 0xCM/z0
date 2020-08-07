//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface ICaptureWorkflow : IDisposable
    {
        ICaptureBroker Broker {get;}

        ICaptureContext Context {get;}
    }
}