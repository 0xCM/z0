//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a memory operand representation
    /// </summary>
    [Free]
    public interface IMemOp : IAsmOp
    {
        AsmSize Size {get;}

        AsmAddress Address {get;}
    }

    [Free]
    public interface IMemOp<T> : IMemOp, IAsmOp<T>
        where T : unmanaged
    {
        AsmOpClass IAsmOp.OpClass
            => AsmOpClass.M;
    }

    public interface IMemOp8 : IMemOp
    {
        AsmSize IMemOp.Size
            => AsmSizeClass.@byte;
    }

    public interface IMemOp8<T> : IMemOp8, IMemOp<T>
        where T : unmanaged, IMemOp8<T>
    {

    }

    public interface IMemOp16 : IMemOp
    {
        AsmSize IMemOp.Size
            => AsmSizeClass.word;
    }

    public interface IMemOp16<T> : IMemOp16, IMemOp<T>
        where T : unmanaged, IMemOp16<T>
    {

    }

    public interface IMemOp32 : IMemOp
    {
        AsmSize IMemOp.Size
            => AsmSizeClass.dword;
    }

    public interface IMemOp32<T> : IMemOp32, IMemOp<T>
        where T : unmanaged, IMemOp32<T>
    {

    }

    public interface IMemOp64 : IMemOp
    {

        AsmSize IMemOp.Size
            => AsmSizeClass.qword;
    }

    public interface IMemOp64<T> : IMemOp64, IMemOp<T>
        where T : unmanaged, IMemOp64<T>
    {


    }

    public interface IMemOp128 : IMemOp
    {
        AsmSize IMemOp.Size
            => AsmSizeClass.xmmword;
    }

    public interface IMemOp128<T> : IMemOp128, IMemOp<T>
        where T : unmanaged, IMemOp128<T>
    {

    }

    public interface IMemOp256 : IMemOp
    {

        AsmSize IMemOp.Size
            => AsmSizeClass.ymmword;
    }

    public interface IMemOp256<T> :  IMemOp256, IMemOp<T>
        where T : unmanaged, IMemOp256<T>
    {
    }

    public interface IMemOp512 : IMemOp
    {
        AsmSize IMemOp.Size
            => AsmSizeClass.zmmword;
    }

    public interface IMemOp512<T> : IMemOp512, IMemOp<T>
        where T : unmanaged, IMemOp512<T>
    {
    }

    [Free]
    public interface IMemOp<F,W,T> : IMemOp<T>
        where T : unmanaged
        where F : unmanaged, IMemOp<F,W,T>
        where W : unmanaged, ITypeWidth
    {
        W Width => default(W);

    }
}