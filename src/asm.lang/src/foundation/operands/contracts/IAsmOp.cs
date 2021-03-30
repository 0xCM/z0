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
        dynamic Content {get;}
    }

    [Free]
    public interface IOperand<T> : IOperand
    {
        new T Content {get;}

        dynamic IOperand.Content
            => Content;
    }

    public interface IAsmOp : ISized, IOperand
    {
        AsmOpKind OpKind {get;}

        AsmOpClass OpClass
            => (AsmOpClass)OpKind;
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