//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{    
    public sealed class ImmEmissionBroker : EventBroker<ImmEmissionBroker,IImmEmissionBroker>, IImmEmissionBroker
    {        
        ImmEmissionBroker(FilePath target)
            : base(target)
        {

        }

        public static ImmEmissionBroker Allocate(FilePath target)
            => new ImmEmissionBroker(target);           
        
    }    

    public interface IImmEmissionBroker : IPersistentBroker
    {
        EmittedEmbeddedImm EmittedEmbeddedImm => EmittedEmbeddedImm.Empty;

        FileEmissionFailed HostFileEmissionFailed => FileEmissionFailed.Empty;

        ImmInjectionFailed ImmInjectionFailed => ImmInjectionFailed.Empty;
    }
}