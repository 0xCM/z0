//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface ICaptureSteps : ICaptureStep
    {
        IManageCaptureStep Manage {get;}

        IExtractMembersStep Extract {get;}

        IDecodeStep Decode {get;}

        IParseMembersStep Parse {get;}

        IEmissionMatchStep MatchEmissions {get;}                    

        IReportParsedStep ReportParsed {get;}        

        IReportExtractsStep ReportExtracts {get;}
    }
}