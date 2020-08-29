//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = Kinds;

    public interface IEvalDispatcher
    {
        bit EvalFixedOperators(BufferTokens buffers, X86ApiMember[] api);

        void Dispatch(BufferTokens buffers, in X86ApiMember api, BinaryOpClass k);

        void Dispatch(BufferTokens buffers, in X86ApiMember api, K.UnaryOpClass k);

        bit EvalFixedOperator(BufferTokens buffers, in X86ApiMember api);
    }
}