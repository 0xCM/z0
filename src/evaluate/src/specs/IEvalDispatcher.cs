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
        bit EvalFixedOperators(BufferTokens buffers, MemberCode[] api);

        void Dispatch(BufferTokens buffers, in MemberCode api, K.BinaryOpClass k);    

        void Dispatch(BufferTokens buffers, in MemberCode api, K.UnaryOpClass k);    

        bit EvalFixedOperator(BufferTokens buffers, in MemberCode api);
    }
}