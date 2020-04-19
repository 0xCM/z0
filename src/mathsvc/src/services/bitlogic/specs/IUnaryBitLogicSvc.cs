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
    public interface IUnaryBitLogicSvc<T> : IUnaryOpSvc<T>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBitLogicSvc<K,T> : IUnaryBitLogicSvc<T>, IBitLogicKind<K,T>
        where K : unmanaged, IBitLogicKind
        where T : unmanaged
    {

    }
}