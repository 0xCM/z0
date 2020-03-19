//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;
    using C = OpClasses;

    interface IAsmEvalDispatcher : IAsmWorkflowService
    {
        bit EvalOperator(in BufferSeq buffers, ApiMemberCode api);        

        bit EvalOperators(in BufferSeq buffers, ApiMemberCode[] api);

        bit EvalFixedOperators(in BufferSeq buffers, ApiMemberCode[] api);

        bit EvalFixedOperator(in BufferSeq buffers, in ApiMemberCode api);
    }

    public interface IApiEvaluator<C>
        where C : IOpClass
    {

    }

    public interface IApiEvaluator<C,T> : IApiEvaluator<C>, IAsmWorkflowService
        where C : IOpClass
        where T : unmanaged
    {

    }

    public readonly ref struct ApiEvalContext
    {
        public readonly BufferSeq Buffers;        

        public readonly ApiMemberCode ApiCode;

        [MethodImpl(Inline)]
        public static ApiEvalContext Define(in BufferSeq buffers, in ApiMemberCode code)
            => new ApiEvalContext(buffers,code);

        [MethodImpl(Inline)]
        ApiEvalContext(in BufferSeq buffers, in ApiMemberCode code)
        {
            this.Buffers = buffers;
            this.ApiCode = code;
        }        
    }
}