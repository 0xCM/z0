//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IHostedApiMethod : IApiMethod
    {
        IApiHost Host {get;}
    }

    public interface IApiMember<T> : IApiMember, IEquatable<T>, ITextual<T>, INullary<T>, IComparable<T>
        where T : struct, IApiMember<T>
    {

    }
}