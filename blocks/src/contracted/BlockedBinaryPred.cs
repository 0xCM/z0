//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedPred16<T> : IBlockedOp<N16,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block16<T> a, in Block16<T> b, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedPred32<T> : IBlockedOp<N32,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block32<T> a, in Block32<T> b, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedPred64<T> : IBlockedOp<N64,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block64<T> a, in Block64<T> b, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedPred128<T> : IBlockedOp<N128,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block128<T> a, in Block128<T> b, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedPred256<T> : IBlockedOp<N256,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block256<T> a, in Block256<T> b, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedPred512<T> : IBlockedOp<N512,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block512<T> a, in Block512<T> b, Span<bit> dst);
    }

}