//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

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
    /// <typeparam name="T">The reifying type</typeparam>
    public interface ITuple<T> : ITuple, IEquatable<T>
        where T : ITuple<T>
    {

    }

    /// <summary>
    /// Characterizes a non-homogenous 2-tuple
    /// </summary>
    /// <typeparam name="T">The reifying type</typeparam>
    /// <typeparam name="T0">The first member type</typeparam>
    /// <typeparam name="T1">The second member type</typeparam>
    public interface ITuple<T,T0,T1> : ITuple<T>
        where T : ITuple<T,T0,T1>        
    {
        void Deconstruct(out T0 x0, out T1 x1);    

        T0 Get(N0 n);

        T1 Get(N1 n);
    }

    /// <summary>
    /// Characterizes a non-homogenous 3-tuple
    /// </summary>
    /// <typeparam name="T">The reifying type</typeparam>
    /// <typeparam name="T0">The first member type</typeparam>
    /// <typeparam name="T1">The second member type</typeparam>
    /// <typeparam name="T2">The third member type</typeparam>
    public interface ITuple<T,T0,T1,T2> : ITuple<T>
        where T : ITuple<T,T0,T1,T2>
    {
        void Deconstruct(out T0 x0, out T1 x1, out T2 x2);                

        T0 Get(N0 n);

        T1 Get(N1 n);

        T2 Get(N2 n);
    }

    public interface ITuple<T,T0,T1,T2,T3> : ITuple<T>
        where T : ITuple<T,T0,T1,T2,T3>
    {
        void Deconstruct(out T0 x0, out T1 x1, out T2 x2, out T3 x3);                
    }


    public interface IMutableTuple<T,T0,T1> : ITuple<T,T0,T1>
        where T : IMutableTuple<T,T0,T1>
    {        
        void Set(N0 n, T0 x);

        void Set(N1 n, T1 x);        
    }

    public interface IMutableTuple<T,T0,T1,T2> : ITuple<T,T0,T1,T2>
        where T : IMutableTuple<T,T0,T1,T2>
    {
        void Set(N0 n, T0 x);

        void Set(N1 n, T1 x);

        void Set(N2 n, T2 x);
    }

    public interface IMutableTuple<T,T0,T1,T2,T3> : ITuple<T,T0,T1,T2,T3>
        where T : IMutableTuple<T,T0,T1,T2,T3>
    {
        void Set(N0 n, T0 x);

        void Set(N1 n, T1 x);

        void Set(N2 n, T2 x);

        void Set(N3 n, T3 x);
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