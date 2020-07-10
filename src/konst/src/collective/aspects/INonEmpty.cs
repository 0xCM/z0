//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a reification of the counterpoint to a nullary thing
    /// </summary>
    /// <typeparam name="F">The thing which cannot be empty</typeparam>
    public interface INonEmpty<F> : INullity, IReified<F>
        where F : INonEmpty<F>, new()
    {
        bool INullity.IsEmpty 
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

    /// <summary>
    /// Characterizes a reified nonempty set
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    public interface INonempySet<F> : INonEmpty<F>
        where F : INonempySet<F>, new()
    {

    }

    /// <summary>
    /// Characterizes a reified nonempty set with evidence of non-absence
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="T">The member type</typeparam>
    public interface NonempySet<F,T> : INonempySet<F>, INonEmpty<F,T>
        where F : NonempySet<F,T>, new()
    {

    }
}