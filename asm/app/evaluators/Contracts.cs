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
    using C = OpClass;

    interface IAsmEvalDispatcher : IAsmService
    {

        bit EvalFixedOperators(in BufferSeq buffers, ApiMemberCode[] api);

        void Dispatch(in BufferSeq buffers, in ApiMemberCode api, C.BinaryOp k);    

        bit EvalFixedOperator(in BufferSeq buffers, in ApiMemberCode api);
    }

    public interface IApiEvaluator<C>
        where C : IOperationClass
    {

    }

    public interface IApiEvaluator<C,T> : IApiEvaluator<C>, IAsmService
        where C : IOperationClass
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