//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = Kinds;

    public interface IEvalDispatcher
    {
        bit EvalFixedOperators(BufferTokens buffers, ApiMemberHex[] api);

        void Dispatch(BufferTokens buffers, in ApiMemberHex api, BinaryOpClass k);

        void Dispatch(BufferTokens buffers, in ApiMemberHex api, K.UnaryOpClass k);

        bit EvalFixedOperator(BufferTokens buffers, in ApiMemberHex api);
    }
}