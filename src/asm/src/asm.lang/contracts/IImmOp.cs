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

    public interface IImmOp8 : IImmOp
    {

    }

    public interface IImmOp8<T> : IImmOp8, IImmOp<T>
        where T : unmanaged
    {

    }

    public interface IImmOp16 : IImmOp
    {

    }

    public interface IImmOp16<T> : IImmOp16, IImmOp<T>
        where T : unmanaged
    {

    }

    public interface IImmOp32 : IImmOp
    {

    }

    public interface IImmOp32<T> : IImmOp32, IImmOp<T>
        where T : unmanaged
    {

    }

    public interface IImmOp64 : IImmOp
    {

    }

    public interface IImmOp64<T> : IImmOp64, IImmOp<T>
        where T : unmanaged
    {

    }

}