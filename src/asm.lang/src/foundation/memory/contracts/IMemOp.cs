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

    public interface IMemOp8 : IMemOp
    {

    }

    public interface IMemOp8<T> : IMemOp8, IMemOp<T>
        where T : unmanaged
    {
    }

    public interface IMemOp16 : IMemOp
    {

    }

    public interface IMemOp16<T> : IMemOp16, IMemOp<T>
        where T : unmanaged
    {
    }

    public interface IMemOp32 : IMemOp
    {

    }

    public interface IMemOp32<T> : IMemOp32, IMemOp<T>
        where T : unmanaged
    {
    }

    public interface IMemOp64 : IMemOp
    {

    }

    public interface IMemOp64<T> : IMemOp64, IMemOp<T>
        where T : unmanaged
    {
    }

    public interface IMemOp128 : IMemOp
    {

    }

    public interface IMemOp128<T> : IMemOp128, IMemOp<T>
        where T : unmanaged
    {
    }

    public interface IMemOp256 : IMemOp
    {

    }

    public interface IMemOp256<T> :  IMemOp256, IMemOp<T>
        where T : unmanaged
    {
    }

    public interface IMemOp512 : IMemOp
    {

    }

    public interface IMemOp512<T> : IMemOp512, IMemOp<T>
        where T : unmanaged
    {
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