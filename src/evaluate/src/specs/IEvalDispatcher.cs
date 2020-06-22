//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = Kinds;

    interface IEvalDispatcher : IService
    {
        bit EvalFixedOperators(BufferTokens buffers, ApiCode[] api);

        void Dispatch(BufferTokens buffers, in ApiCode api, K.BinaryOpClass k);    

        void Dispatch(BufferTokens buffers, in ApiCode api, K.UnaryOpClass k);    

        bit EvalFixedOperator(BufferTokens buffers, in ApiCode api);
    }
}