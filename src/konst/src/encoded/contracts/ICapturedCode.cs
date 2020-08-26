//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface ICapturedCode<H> : IComparable<H>, IEquatable<H>, ITextual, IEncoded<H>
        where H : struct, ICapturedCode<H>
    {

    }

    public interface ICapturedCode<H,T> : ICapturedCode<H>, IEncoded<H,T>
        where H : struct, ICapturedCode<H,T>
        where T : struct, IEncoded<T>
    {

    }
}