//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Characterizes an asm operand representation
    /// </summary>
    public interface IAsmOp : ISized
    {
        AsmOpClass OpClass => default;
    }

    public interface IAsmOp<T> : IAsmOp, ISized<T>
        where T : unmanaged
    {

    }
}