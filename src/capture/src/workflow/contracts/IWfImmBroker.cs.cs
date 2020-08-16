//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{    
    public interface IWfImmBroker : IWfBroker
    {
        EmittedEmbeddedImm EmittedEmbeddedImm => default;

        FileEmissionFailed HostFileEmissionFailed => default;

        ImmInjectionFailed ImmInjectionFailed => default;
    }    
}