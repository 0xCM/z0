//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{    
    public sealed class ImmBroker : WfBroker, IImmBroker
    {        
        ImmBroker(FilePath target)
            : base(target)
        {

        }

        public static ImmBroker create(FilePath target)
            => new ImmBroker(target);                   
    }    

    public interface IImmBroker : IWfBroker
    {
        EmittedEmbeddedImm EmittedEmbeddedImm => EmittedEmbeddedImm.Empty;

        FileEmissionFailed HostFileEmissionFailed => FileEmissionFailed.Empty;

        ImmInjectionFailed ImmInjectionFailed => ImmInjectionFailed.Empty;
    }    
}