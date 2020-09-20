//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes non-parametric aspects of a user-defined data type
    /// </summary>
    public interface IDataType : ITextual, IHashed, INullity
    {

    }
    
    /// <summary>
    /// Characterizes the shape of a user-defined structural data type
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    public interface IDataType<F> : IDataType, IEquatable<F>, INullary<F>
        where F : struct, IDataType<F>
    {
        F INullary<F>.Zero 
            => default;
    }
    
    /// <summary>
    /// Characterizes the shape of a user-defined structural data type
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="T"></typeparam>
    public interface IDataType<F,T> : IDataType<F>, INullary<F,T>
        where F : struct, IDataType<F,T>
    {

    }
}