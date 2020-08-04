//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{    
    public interface ICaptureBroker : IImmBroker, ICaptureEvents
    {        

    }

    public interface ICaptureEvents
    {
        WfError Error => default;

        WfStatus Status => default;

        CapturingHosts CapturingHosts => default;
        
        ExtractReportCreated ExtractReportCreated => default;

        WorkflowError WorkflowError => default;

        ExtractedMembers ExtractedMembers => default;

        ExtractReportSaved ExtractReportSaved => default;

        FunctionsDecoded FunctionsDecoded => default;

        MembersLocated MembersLocated => default;

        ClearedDirectory ClearedDirectory => default;

        MatchedCapturedEmissions MatchedEmissions => default;

        CapturingPart CapturingPart => default;

        CapturedPart CapturedPart => default;

        CapturingHost CapturingHost => default;

        CapturedHost CapturedHost => default;

        HexCodeSaved HexSaved => default;

        ExtractParseFailed ExtractParseFailed => default;

        ExtractsParsed ExtractsParsed => default;
        
        ParseReportEmitted ParseReportCreated => default;

        ClearedPartFiles ClearedPartFiles => default;                   
    }
 
}