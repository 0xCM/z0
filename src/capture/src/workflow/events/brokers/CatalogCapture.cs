//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static AsmEvents;

    public interface ICatalogCaptureRelay : IStepBroker
    {
        StepStart<IApiCatalog> CaptureCatalogStart => StepStarted<IApiCatalog>();

        StepEnd<IApiCatalog> CaptureCatalogEnd => StepEnded<IApiCatalog>();

        PurgedArchiveFolder PurgedArchiveFolder => PurgedArchiveFolder.Empty;        
    }
}