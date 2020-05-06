//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a type which may or may not have/attain a zero-value
    /// or an otherwise empty state.
    /// </summary>
    public interface INullaryKnown
    {
        bool IsEmpty {get;}
    }

    /// <summary>
    /// Characterizes an additve structure S for which there exists a distinguished 
    /// element 0:S such that for every s:S, s + 0 = s
    /// </summary>
    /// <typeparam name="S">The zero value type</typeparam>
    public interface INullary<S>
    {
        /// <summary>
        /// Specifies the zero value
        /// </summary>
        S Zero {get;}     
    }

    public interface INullary<F,T> : INullary<F>, INullaryKnown
        where F : INullary<F,T>, new()
    {
        F INullary<F>.Zero => new F();

        bool INullaryKnown.IsEmpty => this.Equals(Zero);

    }

    /// <summary>
    /// Characterizes a reification of the counterpoint to a nullary thing
    /// </summary>
    /// <typeparam name="F">The thing which cannot be empty</typeparam>
    public interface INonEmpty<F> : INullaryKnown
        where F : INonEmpty<F>, new()
    {
        bool INullaryKnown.IsEmpty 
            => false;
    }

    /// <summary>
    /// Characterizes a T-parametric nonempty thing that provides evidence of non-abscence
    /// </summary>
    /// <typeparam name="F">The thing which cannot be empty</typeparam>
    public interface INonEmpty<F,T> : INonEmpty<F>
        where F : INonEmpty<F,T>, new()
    {
        /// <summary>
        /// Proof
        /// </summary>
        T Individual {get;}
    }    
}