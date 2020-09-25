//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IUnaryRefOp<W,T> : IFuncWT<W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        void Invoke(in T src, ref T dst);
    }

    [Free]
    public interface IUnaryRefStepOp<W,T> : IFuncWT<W,T>
        where T : unmanaged
        where W : unmanaged, ITypeWidth
    {
        void Invoke(int count, int step, in T src, ref T dst);
    }
}