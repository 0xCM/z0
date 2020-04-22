//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public interface ICheckSF128<S,T> : ISFuncApi<S, Vector128<T>, bit>
        where S : unmanaged
        where T : unmanaged
    {
        
    }

}