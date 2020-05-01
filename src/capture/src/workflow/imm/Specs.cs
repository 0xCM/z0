//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Seed;
    using static Memories;
    using static ImmEmissionEvents;
    using static CaptureWorkflowEvents;

    public interface IImmEmissionBroker : IEventBroker
    {
        EmittedEmbeddedImm EmittedEmbeddedImm => EmittedEmbeddedImm.Empty;

        FileEmissionFailed HostFileEmissionFailed => FileEmissionFailed.Empty;

        ImmInjectionFailed ImmInjectionFailed => ImmInjectionFailed.Empty;
    }

    public interface IImmEmissionWorkflow : IWorkflow<IImmEmissionBroker>
    {
        void EmitLiteral(params byte[] imm8);

        void EmitRefined();

        void ClearArchive();        
    }
}