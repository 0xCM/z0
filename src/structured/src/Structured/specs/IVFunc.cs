//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IFunc128<T> : IFuncW<W128>
        where T : unmanaged
    {
        Vec128Kind<T> VKind 
            => default;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IFunc256<T> : IFuncW<W256>
        where T : unmanaged
    {
        Vec256Kind<T> VKind 
            => default;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IFunc512<T> : IFuncW<W512>
        where T : unmanaged
    {
        Vec512Kind<T> VKind 
            => default;
    }
}