//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IMemOp : IAsmOp
    {

    }

    [Free]
    public interface IMemOp<T> : IMemOp, IAsmOp<T>
        where T : unmanaged
    {
        AsmOpKind IAsmOp.OpKind
            => AsmOpKind.M | (AsmOpKind)memory.size<T>();
    }


    [Free]
    public interface IMemOp<F,W,T> : IMemOp<T>
        where T : unmanaged
        where F : unmanaged, IMemOp<F,W,T>
        where W : unmanaged, ITypeWidth
    {
        new W Width => default(W);

        BitWidth ISized.Width
            => Width.BitWidth;
    }
}