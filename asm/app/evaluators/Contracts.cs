//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    using C = Kinds;

    interface IEvalDispatcher : IService
    {

        bit EvalFixedOperators(in BufferSeq buffers, ApiMemberCode[] api);

        void Dispatch(in BufferSeq buffers, in ApiMemberCode api, C.BinaryOpClass k);    

        bit EvalFixedOperator(in BufferSeq buffers, in ApiMemberCode api);
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