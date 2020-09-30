//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IBranchMap<S,T>
        where S : unmanaged
    {
        T Apply(S src);

    }

    public interface IBranchMap<H,S,T> : IBranchMap<S,T>
        where S : unmanaged
        where H : struct, IBranchMap<H,S,T>
    {
    }
}