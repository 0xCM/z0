//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Characterizes a type for which commutative additivity can be defined
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IAdditiveOps<T> : ICommutativeOps<T>
    {
        /// <summary>
        /// Alias for commutative semigroup composition operator
        /// </summary>
        /// <param name="lhs">The first element</param>
        /// <param name="rhs">The second element</param>
        T Add(T lhs, T rhs);                    
    }

    public interface IAdditive<T>
    {
        T Add(T src);
    }
    
    /// <summary>
    /// Characterizes a structure that supports semigroup additivity
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    public interface IAdditive<F,T> : IAdditive<T>, ICommutative<T>
        where F : IAdditive<F,T>, new()
    {        
    }
}