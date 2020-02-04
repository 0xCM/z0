//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static RootShare;

    public interface INumeric : IComparable, IConvertible, IFormattable
    {

    }

    public interface INumeric<T> : IComparable<T>, IConvertible, IFormattable, IEquatable<T>
        where T : unmanaged
    {
        
    }
}