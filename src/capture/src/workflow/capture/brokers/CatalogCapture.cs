//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static CaptureWorkflowEvents;

    public interface ICatalogCaptureBroker : IStepBroker
    {
        StepStart<IApiCatalog> CaptureCatalogStart => StepStarted<IApiCatalog>();

        StepEnd<IApiCatalog> CaptureCatalogEnd => StepEnded<IApiCatalog>();

        PurgedArchiveFolder PurgedArchiveFolder => PurgedArchiveFolder.Empty;        

        MatchedEmissions MatchedEmissions => MatchedEmissions.Empty;        
    }

    public interface ICatalogCaptureClient<C> : IBrokerClient<C>
        where C : ICatalogCaptureBroker
    {
        void OnEvent(StepStart<IApiCatalog> e) 
            => Sink.Deposit(e);

        void OnEvent(StepEnd<IApiCatalog> e) 
            => Sink.Deposit(e);

        void OnEvent(PurgedArchiveFolder e) 
            => Sink.Deposit(e);

        void OnEvent(MatchedEmissions e) 
            => Sink.Deposit(e);
    }
}