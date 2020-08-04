//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface ICaptureWorkflow : IServiceAllocation
    {
        ICaptureBroker Broker {get;}

        ICaptureContext Context {get;}

        MatchAddresses MatchAddresses 
            => new MatchAddresses(this);

        EmitExtractReport ReportExtracts
            => new EmitExtractReport(this);
    }
}