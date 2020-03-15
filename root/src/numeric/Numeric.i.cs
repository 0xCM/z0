//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static Root;

    /// <summary>
    /// Chracterizes a numeric thing
    /// </summary>
    public interface INumeric : IComparable, IConvertible, IFormattable
    {

    }

    /// <summary>
    /// Chracterizes a parametric numeric thing
    /// </summary>
    public interface INumeric<T> : IComparable<T>, IConvertible, IFormattable, IEquatable<T>
        where T : unmanaged
    {
        
    }

}