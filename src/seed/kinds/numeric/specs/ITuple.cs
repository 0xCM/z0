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
    public interface ITuple<K> : ITuple, IEquatable<K>, ITextual<K>
        where K : ITuple<K>
    {

    }

    /// <summary>
    /// Characterizes a potentially non-homogenous 2-tuple
    /// </summary>
    /// <typeparam name="K">The reifying type</typeparam>
    /// <typeparam name="T0">The first member type</typeparam>
    /// <typeparam name="T1">The second member type</typeparam>
    public interface ITupled<K,T0,T1> : ITuple<K>
        where K : ITupled<K,T0,T1>        
    {
        void Deconstruct(out T0 x0, out T1 x1);    

        /// <summary>
        /// The left member 
        /// </summary>
        T0 Left {get;}        

        /// <summary>
        /// The right member 
        /// </summary>
        T1 Right {get;}

    }

    /// <summary>
    /// Characterizes a potentially non-homogenous 3-tuple
    /// </summary>
    /// <typeparam name="K">The reifying type</typeparam>
    /// <typeparam name="T0">The first member type</typeparam>
    /// <typeparam name="T1">The second member type</typeparam>
    /// <typeparam name="T2">The third member type</typeparam>
    public interface ITupled<K,T0,T1,T2> : ITuple<K>
        where K : ITupled<K,T0,T1,T2>
    {
        void Deconstruct(out T0 x0, out T1 x1, out T2 x2);

        T0 First {get;}        

        T1 Second {get;}

        T2 Third {get;}

    }

    /// <summary>
    /// Characterizes a potentially non-homogenous 4-tuple
    /// </summary>
    /// <typeparam name="K">The reifying type</typeparam>
    /// <typeparam name="T0">The first member type</typeparam>
    /// <typeparam name="T1">The second member type</typeparam>
    /// <typeparam name="T2">The third member type</typeparam>
    /// <typeparam name="T3">The fourth member type</typeparam>
    public interface ITupled<K,T0,T1,T2,T3> : ITuple<K>
        where K : ITupled<K,T0,T1,T2,T3>
    {
        void Deconstruct(out T0 x0, out T1 x1, out T2 x2, out T3 x3);                
    }

    /// <summary>
    /// Characterizes an homogenous 2-tuple
    /// </summary>
    /// <typeparam name="K">The reifying type</typeparam>
    /// <typeparam name="T">The member type</typeparam>
    public interface IPair<K,T> : ITuple<K>, ITupled<K,T,T>
        where K : IPair<K,T>
    {
        /// <summary>
        /// The left member 
        /// </summary>
        new T Left {get;}        

        /// <summary>
        /// The right member 
        /// </summary>
        new T Right {get;}

        T ITupled<K,T,T>.Left => Left;

        T ITupled<K,T,T>.Right => Right;
    }

    /// <summary>
    /// Characterizes an homogenous 3-tuple
    /// </summary>
    /// <typeparam name="K">The reifying type</typeparam>
    /// <typeparam name="T">The member type</typeparam>
    public interface ITriple<K,T> : ITuple<K>, ITupled<K,T,T,T>
        where K : ITriple<K,T>
    {
        new T First {get;}        

        new T Second {get;}

        new T Third {get;}

        T ITupled<K,T,T,T>.First => First;

        T ITupled<K,T,T,T>.Second => Second;

        T ITupled<K,T,T,T>.Third => Third;
    }

    /// <summary>
    /// Characterizes an homogenous 4-tuple
    /// </summary>
    /// <typeparam name="K">The reifying type</typeparam>
    /// <typeparam name="T">The member type</typeparam>
    public interface IQuad<K,T> : ITuple<K>, ITupled<K,T,T,T,T>
        where K : IQuad<K,T>
    {
        T First {get;}        

        T Second {get;}

        T Third {get;}

        T fourth {get;}
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