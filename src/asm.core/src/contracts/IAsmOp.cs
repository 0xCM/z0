//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Characterizes an asm operand representation
    /// </summary>
    public interface IAsmOp
    {
        AsmOpClass OpClass => default;
    }

    public interface IAsmOp<T> : IAsmOp
        where T : unmanaged
    {

    }
}