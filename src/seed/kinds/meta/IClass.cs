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

    /// <summary>
    /// Metaclassification
    /// </summary>
    public interface IClassifier : IMetaclass
    {
        
    }

    public interface IClassified<C>
        where C : unmanaged, IClassifier
    {
        C Class  => default;
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic classifier reification
    /// </summary>
    /// <typeparam name="T">The parametric type</typeparam>    
    public interface IClassF<F> : IClassifier
        where F : IClassF<F>, new()
    {

    }

    /// <summary>
    /// Characterizes a T-parametric classifier
    /// </summary>
    /// <typeparam name="T">The parametric type</typeparam>    
    public interface IClassT<T> : IClassifier
    {

    }

    /// <summary>
    /// Characterizes an F-bound polymorphic T-parametric classifier reification
    /// </summary>
    /// <typeparam name="T">The parametric type</typeparam>    
    public interface IClass<F,T> : IClassF<F>, IClassT<T>
        where F : IClass<F,T>, new()
    {

    }
}