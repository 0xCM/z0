//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Common non-parametric tuple contract
    /// </summary>
    public interface ITuple
    {
        string Format(TupleFormat style);        
    }

    /// <summary>
    /// Common parametric tuple contract
    /// </summary>
    /// <typeparam name="K">The reifying type</typeparam>
    public interface ITuple<K> : ITuple, IEquatable<K>
        where K : ITuple<K>
    {

    }

    public interface IPair<K,T> : ITuple<K>
        where K : IPair<K,T>
    {
        void Deconstruct(out T left, out T right);            
    }

    public interface ITriple<K,T> : ITuple<K>
        where K : ITriple<K,T>
    {
        void Deconstruct(out T first, out T second, out T third);    
    }

    /// <summary>
    /// Characterizes a non-homogenous 2-tuple
    /// </summary>
    /// <typeparam name="T">The reifying type</typeparam>
    /// <typeparam name="T0">The first member type</typeparam>
    /// <typeparam name="T1">The second member type</typeparam>
    public interface ITupled<T,T0,T1> : ITuple<T>
        where T : ITupled<T,T0,T1>        
    {
        void Deconstruct(out T0 x0, out T1 x1);    
    }


    /// <summary>
    /// Characterizes a non-homogenous 3-tuple
    /// </summary>
    /// <typeparam name="T">The reifying type</typeparam>
    /// <typeparam name="T0">The first member type</typeparam>
    /// <typeparam name="T1">The second member type</typeparam>
    /// <typeparam name="T2">The third member type</typeparam>
    public interface ITupled<T,T0,T1,T2> : ITuple<T>
        where T : ITupled<T,T0,T1,T2>
    {
        void Deconstruct(out T0 x0, out T1 x1, out T2 x2);                

    }

    public interface ITupled<T,T0,T1,T2,T3> : ITuple<T>
        where T : ITupled<T,T0,T1,T2,T3>
    {
        void Deconstruct(out T0 x0, out T1 x1, out T2 x2, out T3 x3);                
    }

    /// <summary>
    /// Defines the available tuple format styles that may be applied when representing a tuple as text
    /// </summary>
    public enum TupleFormat
    {
        /// <summary>
        /// Indicates a tuple text representation of the form "(x1,...xn)"
        /// </summary>
        Coordinate,

        /// <summary>
        /// Indicates a tuple text representation of the form "A1xA2x ... xAn"
        /// </summary>
        Dimension,

        /// <summary>
        /// Indicates a tuple text representation of the form "[x1,...xn]"
        /// </summary>
        List,

        /// <summary>
        /// Indicates a tuple text representation of the form "{x1,...xn}"
        /// </summary>
        Record,
    }    
}