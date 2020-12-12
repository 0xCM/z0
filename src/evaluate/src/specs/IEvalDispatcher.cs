//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IEvalDispatcher
    {
        bit EvalCellOperators(BufferTokens buffers, ApiMemberCode[] api);

        void Dispatch(BufferTokens buffers, in ApiMemberCode api, BinaryOpClass k);

        void Dispatch(BufferTokens buffers, in ApiMemberCode api, UnaryOpClass k);

        bit EvalCellOperator(BufferTokens buffers, in ApiMemberCode api);
    }
}