//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IMonadic
    {
        
    }
    
    /// <summary>
    /// Characterizes an untyped optional value
    /// </summary>
    public interface IOption : IMonadic
    {
        /// <summary>
        /// True if a value does exists, false otherwise
        /// </summary>
        bool IsSome { get; }

        /// <summary>
        /// True if a value does not exist, false otherwise
        /// </summary>
        bool IsNone { get; }
    }

    /// <summary>
    /// Characterizes an typed optional value
    /// </summary>
    public interface IOption<T> : IOption
    {
        /// <summary>
        /// The encapsualted value, if any
        /// </summary>
        T Value { get; }
    }

    /// <summary>
    /// Characterizes a set-theoretic pair
    /// </summary>
    /// <typeparam name="A">The type of the left value</typeparam>
    /// <typeparam name="B">The type of the left value</typeparam>
    public interface IPairing<A,B>
    {
        A Left {get;}

        B Right {get;}
    }    

    /// <summary>
    /// Characterizes a set-theoretic dual to Pair
    /// </summary>
    /// <typeparam name="A">The type of the potential left value</typeparam>
    /// <typeparam name="B">The type of the potential left value</typeparam>
    public interface ICopairing<A,B>
    {
        /// <summary>
        /// The potential left value
        /// </summary>
        Option<A> Left {get;}

        /// <summary>
        /// The potential right value
        /// </summary>
        Option<B> Right {get;}        
    }
}