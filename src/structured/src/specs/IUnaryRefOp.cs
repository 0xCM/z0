//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;
    using static Memories;

    public interface IUnaryRefOp<W,T> : IFuncWT<W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        void Invoke(in T src, ref T dst);   
    }

    public interface IUnaryRefStepOp<W,T> : IFuncWT<W,T>
        where T : unmanaged
        where W : unmanaged, ITypeWidth
    {
        void Invoke(int count, int step, in T src, ref T dst);
    }    
}