//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IApiToken : IIdentified
    {

    }

    public interface IApiToken<H,T> : IIdentified, IEquatable<T>, IComparable<T>
        where H : unmanaged, IApiToken<H,T>
    {
        IdentityTargetKind TargetKind {get;}

    }
}