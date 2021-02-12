//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static memory;
    using static Part;
    [Free]
    public interface IRegOp : IAsmOp
    {
        RegisterKind RegKind => default;
    }

    [Free]
    public interface IRegOp<T> : IRegOp, IAsmOp<T>
        where T : unmanaged
    {
        AsmOpKind IAsmOp.OpKind
            => AsmOpKind.R | (AsmOpKind)width<T>(w16);

        BitWidth ISized.Width
            => width<T>();
    }

    [Free]
    public interface IRegOp<F,W,T> : IRegOp<T>
        where T : unmanaged
        where F : unmanaged, IRegOp<F,W,T>
        where W : unmanaged, ITypeWidth
    {
        new W Width => default(W);

        BitWidth ISized.Width
            => Width.BitWidth;
    }
}