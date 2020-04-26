//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

   public interface IHostCaptureBroker : IStepBroker,
        IExtractReportBroker, 
        IMembersLocatedBroker, 
        IHostExtractParseBroker,
        IHostFunctionsDecodedBroker,
        ICatalogCaptureBroker,
        IHostHexSavedBroker,
        IImmEmissionBroker
    {
        
    }
}