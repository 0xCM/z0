//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IApiMember : IApiMethod
    {

    }

    [Free]
    public interface IApiMember<T> : IApiMember, IEquatable<T>, ITextual<T>, INullary<T>, IComparable<T>
        where T : struct, IApiMember<T>
    {

    }
}