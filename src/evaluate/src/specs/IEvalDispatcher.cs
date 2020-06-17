//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    using K = Kinds;

    interface IEvalDispatcher : IService
    {
        bit EvalFixedOperators(BufferTokens buffers, ApiMemberCode[] api);

        void Dispatch(BufferTokens buffers, in ApiMemberCode api, K.BinaryOpClass k);    

        void Dispatch(BufferTokens buffers, in ApiMemberCode api, K.UnaryOpClass k);    

        bit EvalFixedOperator(BufferTokens buffers, in ApiMemberCode api);
    }
}