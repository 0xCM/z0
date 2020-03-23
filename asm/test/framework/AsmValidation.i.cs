//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Validation
{
    using System;
    
    public interface IAsmChecks : IAsmService
    {
        void Execute(in BufferSeq buffers, ApiMemberCode code);        

        void Execute(in BufferSeq buffers, ApiMemberCode[] code);        
    }

    public interface IAsmEvalDispatcher : IAsmService
    {
        bit EvalOperator(in BufferSeq buffers, ApiMemberCode api);        

        bit EvalOperators(in BufferSeq buffers, ApiMemberCode[] api);

        bit EvalFixedOperators(in BufferSeq buffers, ApiMemberCode[] api);

        bit EvalFixedOperator(in BufferSeq buffers, in ApiMemberCode api);
    }
}