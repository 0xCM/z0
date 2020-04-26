//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    using K = Kinds;

    interface IEvalDispatcher : IService
    {
        bit EvalFixedOperators(in BufferSeq buffers, MemberCode[] api);

        void Dispatch(in BufferSeq buffers, in MemberCode api, K.BinaryOpClass k);    

        bit EvalFixedOperator(in BufferSeq buffers, in MemberCode api);
    }
}