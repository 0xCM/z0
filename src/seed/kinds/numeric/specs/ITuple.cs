//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Common non-parametric tuple contract
    /// </summary>
    public interface ITuple
    {
        string Format(TupleFormat style);        
    }

    /// <summary>
    /// Common parametric tuple contract
    /// </summary>
    /// <typeparam name="K">The reifying type</typeparam>
    public interface ITuple<K> : ITuple, IEquatable<K>, ITextual<K>
        where K : ITuple<K>
    {

    }
}