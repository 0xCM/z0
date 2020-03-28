//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IMetaclass
    {
        
    }

    public interface IClassifier : IMetaclass
    {
        
    }

    /// <summary>
    /// Metaclassification
    /// </summary>
    public interface IClass :  IClassifier
    {

    }

    /// <summary>
    /// Characterizes an F-bound polymorphic class
    /// </summary>
    /// <typeparam name="T">The parametric type</typeparam>    
    public interface IClassF<F> : IClass
        where F : IClassF<F>, new()
    {

    }

    /// <summary>
    /// Characterizes a parametric class
    /// </summary>
    /// <typeparam name="T">The parametric type</typeparam>    
    public interface IClassT<T> : IClass
    {

    }

    /// <summary>
    /// Characterizes a F-bound polymorphic and T-parametric class
    /// </summary>
    /// <typeparam name="T">The parametric type</typeparam>    
    public interface IClassT<F,T> : IClassF<F>, IClassT<T>
        where F : IClassT<F,T>, new()
    {

    }
}