//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{    
    sealed class CaptureBroker : EventBroker<CaptureBroker,ICaptureBroker>, ICaptureBroker
    {   
        CaptureBroker(FilePath target)
            : base(target)
        {

        }

        public static ICaptureBroker Allocate(FilePath target)
            => new CaptureBroker(target);           
    }
    
    public interface ICaptureBroker : IPersistentBroker, IImmEmissionBroker
    {        
        AppErrorEvent Error => AppErrorEvent.Empty;

        CapturingHosts CapturingHosts => default;
        
        ExtractReportCreated ExtractReportCreated => ExtractReportCreated.Empty;

        WorkflowError WorkflowError => WorkflowError.Empty;

        ExtractedMembers ExtractedMembers=> ExtractedMembers.Empty;

        ExtractReportSaved ExtractReportSaved => ExtractReportSaved.Empty;                

        FunctionsDecoded FunctionsDecoded => FunctionsDecoded.Empty;

        MembersLocated MembersLocated => MembersLocated.Empty;

        ClearedDirectory ClearedDirectory => ClearedDirectory.Empty;        

        MatchedCapturedEmissions MatchedEmissions => MatchedCapturedEmissions.Empty;        

        CapturingPart CapturingPart => CapturingPart.Empty;

        CapturedPart CapturedPart => CapturedPart.Empty;

        CapturingHost CapturingHost => CapturingHost.Empty;

        CapturedHost CapturedHost => CapturedHost.Empty;

        HexCodeSaved HexSaved => HexCodeSaved.Empty;  

        ExtractParseFailed ExtractParseFailed => ExtractParseFailed.Empty;

        ExtractsParsed ExtractsParsed => ExtractsParsed.Empty;            
        
        ParseReportEmitted ParseReportCreated => ParseReportEmitted.Empty;                      
    }
}