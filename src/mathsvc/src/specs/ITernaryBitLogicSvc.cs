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
    public interface ITernaryBitLogicSvc<T> : ITernaryOpSvc<T>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryBitLogicSvc<K,T> : ITernaryBitLogicSvc<T>, IBitLogicKind<K,T>
        where K : unmanaged, IBitLogicKind
        where T : unmanaged
    {

    }
}