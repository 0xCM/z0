//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IMemoryArg : IAsmArg
    {
        AsmOperandKind IAsmArg.OpKind
            => AsmOperandKind.M;
    }

    public interface IMemoryArg<T> : IMemoryArg, IAsmArg<T>
        where T : unmanaged
    {

    }

    public interface IMemoryArg<W,T> : IMemoryArg<T>, IAsmArg<W,T>
        where T : unmanaged
        where W : unmanaged, ITypeWidth
    {

    }

    public interface IMemoryArg<F,W,T> : IMemoryArg<W,T>, IAsmArg<F,W,T>
        where T : unmanaged
        where F : unmanaged, IMemoryArg<F,W,T>
        where W : unmanaged, ITypeWidth
    {

    }
}