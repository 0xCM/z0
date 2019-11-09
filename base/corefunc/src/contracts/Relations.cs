//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;



    /// <summary>
    /// Characterizes a relation over a set
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    public interface IBinaryRelationOps<T> 
    {
        bool Related(T x, T y);
    }

    /// <summary>
    /// Spcifies that a ~ a for every a:T
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    public interface IReflexiveOps<T> : IBinaryRelationOps<T>
    {

    }


    /// <summary>
    /// Spcifies if a,b:T & a!=b then a ~ b & b ~ a => a = b
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    public interface IAntisymmetricOps<T> : IBinaryRelationOps<T>
    {

    }


    /// <summary>
    /// Spcifies that a ~ b iff b ~ a for every a,b:T
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    public interface ISymmetricOps<T> : IBinaryRelationOps<T>
    {
        
    }


    /// <summary>
    /// Spcifies a ~ b & b ~ c => a ~ c for every a,b,c:T
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    public interface ITransitiveOps<T> : IBinaryRelationOps<T>
    {
        
    }        

    /// <summary>
    ///  Characterizes a reflexive, symmetric and transitive binary relation over a set 
    /// \that, consequently, effects a partition over the set
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Equivalence_relation</remarks>
    public interface IEquivalenceOps<T> : IReflexiveOps<T>, ISymmetricOps<T>, ITransitiveOps<T> 
    { 
        
    }

 
}
