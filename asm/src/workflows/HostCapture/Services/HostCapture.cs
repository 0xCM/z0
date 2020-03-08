//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;
    using static AsmWorkflowReports;

    partial class HostCaptureWorkflow
    {
        readonly struct HostCapture : IHostCapture
        {
            public IAsmContext Context {get;}

            public ApiHost Host {get;}

            [MethodImpl(Inline)]
            public static IHostCapture Create(IAsmContext context, in ApiHost host)
                => new HostCapture(context,host);

            [MethodImpl(Inline)]
            HostCapture(IAsmContext context, ApiHost host)
            {
                this.Context = context;
                this.Host = host;
            }
        }
    }
}