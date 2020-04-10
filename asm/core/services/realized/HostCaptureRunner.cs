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

    using static Seed;
    using static Memories;
    using static HostCaptureSteps;

    public static partial class HostCaptureSteps
    {


    }

    readonly struct HostCaptureRunner : IHostCaptureRunner
    {
        readonly HostCaptureContext Context;

        [MethodImpl(Inline)]
        public HostCaptureRunner(in HostCaptureContext context)
        {
            this.Context = context;
        }            
    
        public void Run(AsmWorkflowConfig config)
        {
            var driver = DriveCatalogCapture.Create(Context);
            driver.CaptureCatalogs(config);
        }
    }   
}