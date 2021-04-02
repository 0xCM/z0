//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IOperand
    {

    }

    [Free]
    public interface IOperand<T> : IOperand
    {
        T Content {get;}

    }

    public interface IAsmOp : ISized, IOperand
    {
        AsmOpKind OpKind {get;}

    }

    public interface IAsmOp<T> : IAsmOp, IOperand<T>
        where T : struct
    {
        BitWidth ISized.Width
            => memory.width<T>();
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