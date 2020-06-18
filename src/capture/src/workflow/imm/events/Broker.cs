//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static ImmEmissionEvents;
    using static CaptureWorkflowEvents;

    public partial class ImmEmissionEvents
    {

        
    }
    
    public sealed class ImmEmissionBroker : EventBroker<ImmEmissionBroker,IImmEmissionBroker>, IImmEmissionBroker
    {        
    
    }    

    public interface IImmEmissionBroker : IEventBroker
    {
        EmittedEmbeddedImm EmittedEmbeddedImm => EmittedEmbeddedImm.Empty;

        FileEmissionFailed HostFileEmissionFailed => FileEmissionFailed.Empty;

        ImmInjectionFailed ImmInjectionFailed => ImmInjectionFailed.Empty;
    }
}