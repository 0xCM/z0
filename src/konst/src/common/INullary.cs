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
    /// <typeparam name="T">The zero value type</typeparam>
    public interface INullary<T>
    {
        /// <summary>
        /// Specifies the zero value
        /// </summary>
        T Zero {get;}     
    }

    public interface INullary<F,T> : INullary<F>, INullity
        where F : INullary<F,T>, new()
    {
        F INullary<F>.Zero 
            => new F();

        bool INullity.IsEmpty 
            => this.Equals(Zero);
    }

    /// <summary>
    /// Advertises a distinguished value One:T such that for every t:T, One*t = t*One = t
    /// for binary operator * over T
    /// </summary>
    /// <typeparam name="T">The unital value type</typeparam>
    public interface IUnital<T> 
    {
        T One {get;}
    }

    /// <summary>
    /// Characterizes a structure with unit
    /// </summary>
    /// <typeparam name="S">The unital value type</typeparam>
    public interface IUnital<F,T> : IUnital<F>
        where F : IUnital<F,T>, new()
    {

    }
}