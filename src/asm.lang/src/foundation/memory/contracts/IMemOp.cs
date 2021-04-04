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
        BitWidth ISized.Width
            => 8;
    }

    public interface IMemOp8<T> : IMemOp8, IMemOp<T>
        where T : unmanaged, IMemOp8<T>
    {

        BitWidth ISized.Width
            => 8;
    }

    public interface IMemOp16 : IMemOp
    {
        BitWidth ISized.Width
            => 16;

    }

    public interface IMemOp16<T> : IMemOp16, IMemOp<T>
        where T : unmanaged, IMemOp16<T>
    {

        BitWidth ISized.Width
            => 16;
    }

    public interface IMemOp32 : IMemOp
    {
        BitWidth ISized.Width
            => 32;

    }

    public interface IMemOp32<T> : IMemOp32, IMemOp<T>
        where T : unmanaged, IMemOp32<T>
    {
        BitWidth ISized.Width
            => 32;
    }

    public interface IMemOp64 : IMemOp
    {
        BitWidth ISized.Width
            => 64;
    }

    public interface IMemOp64<T> : IMemOp64, IMemOp<T>
        where T : unmanaged, IMemOp64<T>
    {
        BitWidth ISized.Width
            => 64;
    }

    public interface IMemOp128 : IMemOp
    {
        BitWidth ISized.Width
            => 128;

    }

    public interface IMemOp128<T> : IMemOp128, IMemOp<T>
        where T : unmanaged, IMemOp128<T>
    {
        BitWidth ISized.Width
            => 128;
    }

    public interface IMemOp256 : IMemOp
    {
        BitWidth ISized.Width
            => 256;
    }

    public interface IMemOp256<T> :  IMemOp256, IMemOp<T>
        where T : unmanaged, IMemOp256<T>
    {
        BitWidth ISized.Width
            => 256;
    }

    public interface IMemOp512 : IMemOp
    {
        BitWidth ISized.Width
            => 512;

    }

    public interface IMemOp512<T> : IMemOp512, IMemOp<T>
        where T : unmanaged, IMemOp512<T>
    {
        BitWidth ISized.Width
            => 512;
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