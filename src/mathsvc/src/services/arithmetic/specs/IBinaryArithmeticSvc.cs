//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;        

    using static Seed; 

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryArithmeticSvc<T> : IBinaryOpSvc<T>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryArithmeticSvc<K,T> : IBinaryArithmeticSvc<T>, IArithmeticKind<K,T>
        where K : unmanaged, IArithmeticKind
        where T : unmanaged
    {

    }
}