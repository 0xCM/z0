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
        AsmSizeKind SizeKind  {get;}

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
        BitWidth ISized.Width
            => 8;

        ByteSize ISized.Size
            => 1;

        AsmSizeKind IMemOp.SizeKind
            => AsmSizeKind.@byte;
    }

    public interface IMemOp8<T> : IMemOp8, IMemOp<T>
        where T : unmanaged, IMemOp8<T>
    {

        BitWidth ISized.Width
            => 8;

        ByteSize ISized.Size
            => 1;
    }

    public interface IMemOp16 : IMemOp
    {
        BitWidth ISized.Width
            => 16;

        ByteSize ISized.Size
            => 2;

        AsmSizeKind IMemOp.SizeKind
            => AsmSizeKind.word;
    }

    public interface IMemOp16<T> : IMemOp16, IMemOp<T>
        where T : unmanaged, IMemOp16<T>
    {
        BitWidth ISized.Width
            => 16;

        ByteSize ISized.Size
            => 2;
    }

    public interface IMemOp32 : IMemOp
    {
        BitWidth ISized.Width
            => 32;

        ByteSize ISized.Size
            => 4;

        AsmSizeKind IMemOp.SizeKind
            => AsmSizeKind.dword;
    }

    public interface IMemOp32<T> : IMemOp32, IMemOp<T>
        where T : unmanaged, IMemOp32<T>
    {
        BitWidth ISized.Width
            => 32;

        ByteSize ISized.Size
            => 4;
    }

    public interface IMemOp64 : IMemOp
    {
        BitWidth ISized.Width
            => 64;

        ByteSize ISized.Size
            => 8;

        AsmSizeKind IMemOp.SizeKind
            => AsmSizeKind.qword;
    }

    public interface IMemOp64<T> : IMemOp64, IMemOp<T>
        where T : unmanaged, IMemOp64<T>
    {
        BitWidth ISized.Width
            => 64;

        ByteSize ISized.Size
            => 8;
    }

    public interface IMemOp128 : IMemOp
    {
        BitWidth ISized.Width
            => 128;

        ByteSize ISized.Size
            => 16;

        AsmSizeKind IMemOp.SizeKind
            => AsmSizeKind.xmmword;
    }

    public interface IMemOp128<T> : IMemOp128, IMemOp<T>
        where T : unmanaged, IMemOp128<T>
    {
        BitWidth ISized.Width
            => 128;

        ByteSize ISized.Size
            => 16;
    }

    public interface IMemOp256 : IMemOp
    {
        BitWidth ISized.Width
            => 256;

        ByteSize ISized.Size
            => 32;

        AsmSizeKind IMemOp.SizeKind
            => AsmSizeKind.ymmword;
    }

    public interface IMemOp256<T> :  IMemOp256, IMemOp<T>
        where T : unmanaged, IMemOp256<T>
    {
        BitWidth ISized.Width
            => 256;

        ByteSize ISized.Size
            => 32;
    }

    public interface IMemOp512 : IMemOp
    {
        BitWidth ISized.Width
            => 512;

        ByteSize ISized.Size
            => 64;

        AsmSizeKind IMemOp.SizeKind
            => AsmSizeKind.zmmword;
    }

    public interface IMemOp512<T> : IMemOp512, IMemOp<T>
        where T : unmanaged, IMemOp512<T>
    {
        BitWidth ISized.Width
            => 512;

        ByteSize ISized.Size
            => 64;
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

        ByteSize ISized.Size
            => Width.BitWidth/8;
    }
}