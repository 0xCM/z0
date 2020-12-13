//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IApiToken : IIdentified
    {
        IdentityTargetKind TargetKind {get;}
    }

    [Free]
    public interface IApiToken<H,T> : IApiToken, IEquatable<T>, IComparable<T>
        where H : unmanaged, IApiToken<H,T>
    {

    }
}