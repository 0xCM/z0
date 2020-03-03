//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Security;

    using static Root;

    [SuppressUnmanagedCodeSecurity]
    public interface IVIndexedSource<W,V,T> : IIndexedSource<V>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {

    }

    public interface IVIndexedSource128<T> : IVIndexedSource<N128,Vector128<T>,T>
        where T : unmanaged
    {

    }

    public interface IVIndexedSource256<T> : IVIndexedSource<N256,Vector256<T>,T>
        where T : unmanaged
    {
        
    }


}