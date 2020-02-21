//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

    public interface IIndexedBits<F> : IBitField
        where F : unmanaged, Enum
    {

    }

    public interface INumericBits<T> : IBitField, IFixedNumeric<T>
        where T : unmanaged
    {

    }

    public interface INumericBits<S,T> : INumericBits<T>, INumericFormatProvider<T>
        where T : unmanaged
        where S : INumericBits<T>
    {
        
        INumericFormatter<T> INumericFormatProvider<T>.Formatter
            => NumericFormatters.get<T>();
        
    }

    public interface INumericBits<F,S,T> : INumericBits<S,T>, IIndexedBits<F>
        where F : unmanaged, Enum
        where T : unmanaged
        where S : INumericBits<T>
    {

    }

    /// <summary>
    /// Characterizes an element within a partition of a numeric field
    /// </summary>
    /// <typeparam name="T">The field type over which a partition is defined</typeparam>
    public interface INumericSegment<T> : IFieldSegment<T>
        where T : unmanaged
    {

    }
}