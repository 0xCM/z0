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
    public interface IUnaryArithmeticSvc<T> : ISUnaryOp<T>, IUnarySpanOp<T>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryArithmeticSvc<K,T> : IUnaryArithmeticSvc<T>, IArithmeticKind<K,T>
        where K : unmanaged, IArithmeticKind
        where T : unmanaged
    {

    }
}