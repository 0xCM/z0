//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface IMultiplicative<S>
        where S : IMultiplicative<S>, new()
    {
        S Mul(S rhs);
    }

    /// <summary>
    /// Characterizes structural multiplication
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    /// <typeparam name="T">The individual type</typeparam>
    public interface IMultiplicative<S,T> : IMultiplicative<S>
        where S : IMultiplicative<S,T>, new()
    {
        
    }    
}