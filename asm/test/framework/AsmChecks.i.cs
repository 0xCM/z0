//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Validation
{

    using System;

    public interface IAsmChecks : IAsmWorkflowService
    {
        void CheckExecution(in BufferSeq buffers, ApiMemberCode code);        

        void CheckExecution(in BufferSeq buffers, ApiMemberCode[] code);        
    }

}