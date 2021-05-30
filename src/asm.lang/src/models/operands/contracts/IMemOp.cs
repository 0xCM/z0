//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static AsmTokens;

    /// <summary>
    /// Characterizes a memory operand representation
    /// </summary>
    [Free]
    public interface IMemOp : IAsmOp
    {
        SizeKeyword Qualifier => default;
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

        SizeKeyword IMemOp.Qualifier
            => SizeKeyword.@byte;
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

        SizeKeyword IMemOp.Qualifier
            => SizeKeyword.word;
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

        SizeKeyword IMemOp.Qualifier
            => SizeKeyword.dword;
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

        SizeKeyword IMemOp.Qualifier
            => SizeKeyword.qword;    }

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

        SizeKeyword IMemOp.Qualifier
            => SizeKeyword.xmmword;
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

        SizeKeyword IMemOp.Qualifier
            => SizeKeyword.ymmword;
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

        SizeKeyword IMemOp.Qualifier
            => SizeKeyword.zmmword;
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