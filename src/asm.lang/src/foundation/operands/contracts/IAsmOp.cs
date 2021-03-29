//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmOp : ISizedOperand
    {
        AsmOpKind OpKind {get;}

        AsmOpClass OpClass
            => (AsmOpClass)OpKind;
    }

    public interface IAsmOp<T> : IAsmOp, ISizedOperand<T>
        where T : struct
    {

    }

    public interface IAsmOp<F,W,T> : IAsmOp<T>
        where F : unmanaged, IAsmOp<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        new W Width => default(W);

        BitWidth ISized.Width
            => Width.BitWidth;
    }
}