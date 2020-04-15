//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IImmEmissionWorkflow : IAsmWorkflow
    {
        void Emit(params byte[] immediates);
        
    }

}