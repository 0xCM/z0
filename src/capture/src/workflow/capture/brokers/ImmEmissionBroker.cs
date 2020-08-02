//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{    
    public sealed class ImmEmissionBroker : WfBroker, IImmEmissionBroker
    {        
        ImmEmissionBroker(FilePath target)
            : base(target)
        {

        }

        public static ImmEmissionBroker create(FilePath target)
            => new ImmEmissionBroker(target);                   
    }    

    public interface IImmEmissionBroker : IWfBroker
    {
        EmittedEmbeddedImm EmittedEmbeddedImm => EmittedEmbeddedImm.Empty;

        FileEmissionFailed HostFileEmissionFailed => FileEmissionFailed.Empty;

        ImmInjectionFailed ImmInjectionFailed => ImmInjectionFailed.Empty;
    }    
}