//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IImmOp : IAsmOp
    {
        RegisterKind RegKind => default;
    }

    [Free]
    public interface IImmOp<T> : IImmOp, IAsmOp<T>
        where T : unmanaged
    {
        AsmOpKind IAsmOp.OpKind
            => AsmOpKind.Imm | (AsmOpKind)memory.size<T>();
        BitWidth ISized.Width
            => memory.size<T>();
    }


    [Free]
    public interface IImmOp<F,W,T> : IImmOp<T>
        where T : unmanaged
        where F : unmanaged, IImmOp<F,W,T>
        where W : unmanaged, ITypeWidth
    {
        new W Width => default(W);

        BitWidth ISized.Width
            => Width.BitWidth;
    }
}