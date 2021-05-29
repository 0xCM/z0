//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmTokens;


    /// <summary>
    /// Characterizes an asm operand representation
    /// </summary>
    public interface IAsmOp : ISized
    {
        AsmOpKind OpKind => default;
    }

    public interface IAsmOp<T> : IAsmOp
        where T : struct
    {
        BitWidth ISized.Width
            => core.width<T>();
    }
}