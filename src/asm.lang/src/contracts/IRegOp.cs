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
    public interface IRegOp8 : IRegOp
    {
        // BitWidth ISized.Width
        //     => 8;
    }

    [Free]
    public interface IRegOp8<T> : IRegOp8, IRegOp<T>
        where T : unmanaged
    {

    }

    [Free]
    public interface IRegOp16 : IRegOp
    {
        // BitWidth ISized.Width
        //     => 16;
    }

    [Free]
    public interface IRegOp16<T> : IRegOp16, IRegOp<T>
        where T : unmanaged
    {
    }

    [Free]
    public interface IRegOp32 : IRegOp
    {
        // BitWidth ISized.Width
        //     => 32;
    }

    [Free]
    public interface IRegOp32<T> : IRegOp32, IRegOp<T>
        where T : unmanaged
    {

    }

    [Free]
    public interface IRegOp64 : IRegOp
    {
        // BitWidth ISized.Width
        //     => 64;
    }


    [Free]
    public interface IRegOp64<T> : IRegOp64, IRegOp<T>
        where T : unmanaged
    {
    }

    [Free]
    public interface IRegOp128 : IRegOp
    {
        // BitWidth ISized.Width
        //     => 128;
    }

    [Free]
    public interface IRegOp128<T> : IRegOp128, IRegOp<T>
        where T : unmanaged
    {
    }

    [Free]
    public interface IRegOp256 : IRegOp
    {
        // BitWidth ISized.Width
        //     => 256;
    }

    [Free]
    public interface IRegOp256<T> : IRegOp256, IRegOp<T>
        where T : unmanaged
    {
    }

    [Free]
    public interface IRegOp512 : IRegOp
    {
        // BitWidth ISized.Width
        //     => 512;
    }

    [Free]
    public interface IRegOp512<T> : IRegOp512, IRegOp<T>
        where T : unmanaged
    {
    }
}