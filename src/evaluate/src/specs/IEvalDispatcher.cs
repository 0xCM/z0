//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IEvalDispatcher
    {
        Bit32 EvalFixedOperators(BufferTokens buffers, ApiMemberCode[] api);

        void Dispatch(BufferTokens buffers, in ApiMemberCode api, BinaryOpClass k);

        void Dispatch(BufferTokens buffers, in ApiMemberCode api, UnaryOpClass k);

        Bit32 EvalFixedOperator(BufferTokens buffers, in ApiMemberCode api);
    }
}