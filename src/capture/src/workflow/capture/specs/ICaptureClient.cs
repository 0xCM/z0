//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    public interface ICaptureClient : 
        ICatalogCaptureClient<ICaptureBroker>,
        IExtractReportClient<ICaptureBroker>,
        IMembersLocatedClient<ICaptureBroker>,
        IExtractParseClient<ICaptureBroker>,
        IFunctionsDecodedClient<ICaptureBroker>,
        IHexSavedClient<ICaptureBroker>
    {
        void OnEvent(AppErrorEvent e) 
        {
            Sink.Deposit(e);
        }

        void Connect()
        {
            Broker.Error.Subscribe(Broker,OnEvent);
            Broker.CaptureCatalogStart.Subscribe(Broker,OnEvent);
            Broker.CaptureCatalogEnd.Subscribe(Broker,OnEvent);
            Broker.MembersLocated.Subscribe(Broker,OnEvent);
            Broker.ExtractReportCreated.Subscribe(Broker,OnEvent);
            Broker.ExtractReportSaved.Subscribe(Broker,OnEvent);
            Broker.ParseReportCreated.Subscribe(Broker, OnEvent);
            Broker.FunctionsDecoded.Subscribe(Broker, OnEvent);
            Broker.HexSaved.Subscribe(Broker,OnEvent);
            Broker.ExtractsParsed.Subscribe(Broker,OnEvent);
            Broker.ExtractParseFailed.Subscribe(Broker,OnEvent);
            Broker.MatchedEmissions.Subscribe(Broker, OnEvent);
            Broker.PurgedArchiveFolder.Subscribe(Broker, OnEvent);
        }        
    }
}