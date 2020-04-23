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

    using K = Kinds;

    public interface ICheckSF128<S,T> : ISFunc<S,Vector128<T>,bit>
        where S : unmanaged
        where T : unmanaged
    {
        
    }

    public interface ICheckSF256<S,T> : ISFunc<S, Vector256<T>, bit>
        where S : unmanaged
        where T : unmanaged
    {
        
    }
}