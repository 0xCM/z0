//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
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
}