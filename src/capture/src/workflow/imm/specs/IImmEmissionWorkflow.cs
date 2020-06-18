//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IImmEmissionWorkflow : IWorkflow<IImmEmissionBroker>
    {
        void EmitLiteral(params byte[] imm8);

        void EmitRefined();

        void ClearArchive();        
    }
}