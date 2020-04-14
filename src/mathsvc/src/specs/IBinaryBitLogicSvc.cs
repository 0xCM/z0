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
    public interface IBinaryBitLogicSvc<T> : IBinaryOpSvc<T>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBitLogicSvc<K,T> : IBinaryBitLogicSvc<T>, IBitLogicKind<K,T>
        where K : unmanaged, IBitLogicKind
        where T : unmanaged
    {

    }
}