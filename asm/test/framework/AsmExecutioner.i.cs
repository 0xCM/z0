//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Validation
{
    using System;

    public interface IAsmExecutioner : IAsmWorkflowService
    {
        void CheckExecution(in BufferSeq buffers, ApiMemberCode api);        

        void CheckExecution(in BufferSeq buffers, ApiMemberCode[] api);
    }
}