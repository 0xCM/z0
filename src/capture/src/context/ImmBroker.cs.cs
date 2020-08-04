//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{    
    public sealed class ImmBroker : WfBroker, IImmBroker
    {        
        ImmBroker(FilePath target, CorrelationToken ct)
            : base(target, ct)
        {

        }

        public static ImmBroker create(FilePath target, CorrelationToken ct)
            => new ImmBroker(target, ct);                   
    }    

    public interface IImmBroker : IWfBroker
    {
        EmittedEmbeddedImm EmittedEmbeddedImm => EmittedEmbeddedImm.Empty;

        FileEmissionFailed HostFileEmissionFailed => FileEmissionFailed.Empty;

        ImmInjectionFailed ImmInjectionFailed => ImmInjectionFailed.Empty;
    }    
}