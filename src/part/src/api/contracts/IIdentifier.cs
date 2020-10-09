//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IIdentifier : ITextual
    {

    }

    [Free]
    public interface IIdentifier<T> : IIdentifier
    {
        T Identifier {get;}
    }

    [Free]
    public interface IIdentifier<H,T> : IIdentifier<T>, IEquatable<H>
    {

    }
}