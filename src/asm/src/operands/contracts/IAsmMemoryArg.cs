//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAsmMemoryArg : IAsmArg
    {
        AsmOperandKind IAsmArg.OpKind
            => AsmOperandKind.M;
    }

    public interface IAsmMemoryArg<T> : IAsmMemoryArg, IAsmArg<T>
        where T : unmanaged
    {

    }

    public interface IAsmMemoryArg<W,T> : IAsmMemoryArg<T>, IAsmArg<W,T>
        where T : unmanaged
        where W : unmanaged, ITypeWidth
    {

    }

    public interface IAsmMemoryArg<F,W,T> : IAsmMemoryArg<W,T>, IAsmArg<F,W,T>
        where T : unmanaged
        where F : unmanaged, IAsmMemoryArg<F,W,T>
        where W : unmanaged, ITypeWidth
    {

    }
}