//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ISemigroup<F> : IReified<F>
        where F : ISemigroup<F>, new()
    {

    }

    public interface IMonoid<S> : ISemigroup<S>
        where S : IMonoid<S>, new()
    {

    }

    /// <summary>
    /// Characterizes monoidal structure
    /// </summary>
    /// <typeparam name="S">The classified structure</typeparam>
    /// <typeparam name="T">The underlying type</typeparam>
    public interface IMonoid<S,T> : IMonoid<S>, ISemigroup<S,T>
        where S : IMonoid<S,T>, new()
    {
        
    }            

    public interface IInvertible<F>
        where F : IInvertible<F>, new()
    {
        /// <summary>
        /// Unary structural negation
        /// </summary>
        F Invert();
    }

    public interface IGroup<F> : IMonoid<F>, IInvertible<F>
        where F : IGroup<F>, new()
    {

    }

    public interface ISemigroup<S,T> : ISemigroup<S>
        where S : ISemigroup<S,T>, new()
    {
        
    }            

    public interface IEquivalenceClass<T>
    {
        /// <summary>
        /// The class representative
        /// </summary>
        T Rep {get;}
    }

    /// <summary>
    /// Characterizes an equivalence class, i.e. a segment of a partition effected via 
    /// an equivalence relation
    /// </summary>
    /// <typeparam name="T">The classified type</typeparam>
    public interface IEquivalenceClass<S,T> : ISemigroup<S,T>, IEquivalenceClass<T>, INonEmpty<S>
        where S : IEquivalenceClass<S,T>, new()
    {
        
    }

    /// <summary>
    /// Characterizes a partition over a set effected via an equivalence relation. 
    /// In this context, a parition is a collection of mutually disjoint subsets 
    /// of a given set whose union recovers the original set
    /// </summary>
    /// <typeparam name="C">The equivalence class type</typeparam>
    /// <typeparam name="T">The set domain</typeparam>
    public interface IQuotientSet<C,T> 
        where C : IEquivalenceClass<C,T>, new()
        where T : new()
    {
        /// <summary>
        /// Effects a partition via the equivalence
        /// </summary>
        C[] Partition();

        /// <summary>
        /// The canonical surjective projection from the underlying set to the equivalence 
        /// partitions that maps a given element to the equivalence class in which it
        /// resides
        /// </summary>
        /// <param name="src">The source value</param>
        C Project(T src);
    }

    /// <summary>
    /// Characterizes a totally ordered structure
    /// </summary>
    /// <typeparam name="S">The structure reification type</typeparam>
    public interface IOrdered<S>
        where S : IOrdered<S>, new()
    {   
        /// <summary>
        /// Determines whether this:S & rhs:S => this < rhs
        /// </summary>
        /// <param name="rhs">The operand to compare</param>
        bool Lt(S rhs);
        
        /// <summary>
        /// Determines whether this:S & rhs:S => this <= rhs
        /// </summary>
        /// <param name="rhs">The operand to compare</param>
        bool LtEq(S rhs);
        
        /// <summary>
        /// Determines whether this:S & rhs:S => this > rhs
        /// </summary>
        /// <param name="rhs">The operand to compare</param>
        bool Gt(S rhs);                
        
        /// <summary>
        /// Determines whether this:S & rhs:S => this >= rhs
        /// </summary>
        /// <param name="rhs">The operand to compare</param>
        bool GtEq(S rhs);              
    }        
}