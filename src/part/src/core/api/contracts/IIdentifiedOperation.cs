//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IIdentifiedOperation : IIdentification
    {
        IdentityTargetKind IIdentification.TargetKind
            => IdentityTargetKind.Method;
    }

    [Free]
    public interface IIdentifiedOperation<T> : IIdentifiedOperation, IIdentification<T>
        where T : IIdentifiedOperation<T>, new()
    {
        Func<string,T> Factory  => s => new T();
    }
}