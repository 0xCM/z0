//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static AsmEvents;

    public interface ICatalogCaptureRelay : IWorkflowRelay
    {
        StepStart<IApiCatalog> CaptureCatalogStart => StepStarted<IApiCatalog>();

        StepEnd<IApiCatalog> CaptureCatalogEnd => StepEnded<IApiCatalog>();
    }
}