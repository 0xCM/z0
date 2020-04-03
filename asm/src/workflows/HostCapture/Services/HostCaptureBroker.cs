//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    partial class HostCaptureWorkflow
    {        
        sealed class HostCaptureBroker : AppEventRelay, IHostCaptureEventRelay
        {
            [MethodImpl(Inline)]
            public new static IHostCaptureEventRelay Create()
                => new HostCaptureBroker();
        }
    }
}