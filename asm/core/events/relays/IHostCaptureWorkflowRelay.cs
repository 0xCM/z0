//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

   public interface IHostCaptureWorkflowRelay : 
        IExtractReportRelay, 
        IMemberLocationRelay, 
        IHostExtractParseRelay,
        IHostFunctionsDecodedRelay,
        ICatalogCaptureRelay,
        IHostHexSavedRelay,
        IHostCaptureRelay
    {
        
    }
}