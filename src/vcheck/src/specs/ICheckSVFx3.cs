//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    using K = Kinds;

    public interface ICheckBinarySVFD<W,F,T>
        where T : unmanaged
        where W : ITypeWidth
        where F : IBinaryOp<T>
    {
        void CheckSVF(F f);
    }
}