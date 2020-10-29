//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICapturedCode<H> : IComparable<H>, IEquatable<H>, ITextual, IEncoded<H>
        where H : struct, ICapturedCode<H>
    {

    }

    [Free]
    public interface ICapturedCode<H,T> : ICapturedCode<H>, IEncoded<H,T>
        where H : struct, ICapturedCode<H,T>
        where T : struct, IEncoded<T>
    {

    }
}