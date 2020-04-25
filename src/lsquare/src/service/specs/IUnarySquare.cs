//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    public interface IUnarySquare<T>
        where T : unmanaged
    {
        void Invoke(W128 w, in T src, ref T dst);   

        void Invoke(W128 w, int count, int step, in T src, ref T dst);

        void Invoke(W256 w, in T src, ref T dst);

        void Invoke(W256 w, int count, int step, in T src, ref T dst);
    }

    public interface IUnarySquare<W,T> : IUnaryRefOp<W,T>, IUnaryRefStepOp<W,T>
        where T : unmanaged
        where W : unmanaged, ITypeWidth
    {        
    }
}