//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

   public interface IHostCaptureBroker : IStepBroker,
        IExtractReportRelay, 
        IMembersLocatedRelay, 
        IHostExtractParseRelay,
        IHostFunctionsDecodedRelay,
        ICatalogCaptureRelay,
        IHostHexSavedRelay,
        IImmEmissionStep
    {
        
    }
}