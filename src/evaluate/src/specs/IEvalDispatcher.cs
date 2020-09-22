//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = Kinds;

    public interface IEvalDispatcher
    {
        bit EvalFixedOperators(BufferTokens buffers, ApiMemberCode[] api);

        void Dispatch(BufferTokens buffers, in ApiMemberCode api, BinaryOpClass k);

        void Dispatch(BufferTokens buffers, in ApiMemberCode api, K.UnaryOpClass k);

        bit EvalFixedOperator(BufferTokens buffers, in ApiMemberCode api);
    }
}