//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmTokens;

    public interface IAsmOp : ISized
    {
        AsmOpKind OpKind => default;

    }

    public interface IAsmOp<T> : IAsmOp
        where T : struct
    {
        BitWidth ISized.Width
            => memory.width<T>();
    }
}