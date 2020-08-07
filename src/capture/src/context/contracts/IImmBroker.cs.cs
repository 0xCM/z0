//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IImmBroker : IWfBroker
    {
        EmittedEmbeddedImm EmittedEmbeddedImm => default;

        FileEmissionFailed HostFileEmissionFailed => default;

        ImmInjectionFailed ImmInjectionFailed => default;
    }    
}