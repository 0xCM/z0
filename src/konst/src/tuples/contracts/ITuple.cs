//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Common non-parametric tuple contract
    /// </summary>
    [Free]
    public interface ITuple
    {
        string Format(TupleFormatKind style);
    }

    /// <summary>
    /// Common parametric tuple contract
    /// </summary>
    /// <typeparam name="K">The reifying type</typeparam>
    [Free]
    public interface ITuple<K> : ITuple, IEquatable<K>, ITextual<K>
        where K : ITuple<K>
    {

    }
}