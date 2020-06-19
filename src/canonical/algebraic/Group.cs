//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Characterizes group operations over a type
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IGroupOps<T> : IInvertiveOps<T>, IMonoidOps<T>
        where T : unmanaged

    {
        
    }

    public interface IGroupMOps<T> : IGroupOps<T>, IMonoidMOps<T>, InvertiveMOps<T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes additive/abelian group operations
    /// </summary>
    public interface IGroupAOps<T> : IGroupOps<T>, IMonoidAOps<T>, INegatableOps<T> 
        where T : unmanaged
    {

    }

    public interface IGroupLike<S> : IInvertive<S>, IMonoid<S>
        where S : IGroupLike<S>, new()
    {

    }

    public interface IGroupM<S> : IGroupLike<S>, IMonoidM<S>
        where S : IGroupM<S>, new()
    {
        
    }    

    public interface IGroupA<S> : IGroupLike<S>, IMonoidA<S>
        where S : IGroupA<S>, new()
    {
        /// <summary>
        /// Unary structural negation
        /// </summary>
        S Invert();

    }
    
    /// <summary>
    /// Characterizes a group structure
    /// </summary>
    /// <typeparam name="T">The type over which the structure is defind</typeparam>
    /// <typeparam name="S">The structure type</typeparam>
    public interface IGroupLike<S,T> : IGroupLike<S>
        where S : IGroupLike<S,T>, new()
    {
        
    }

    /// <summary>
    /// Characterizes a multiplicative group structure
    /// </summary>
    /// <typeparam name="T">The type over which the structure is defind</typeparam>
    /// <typeparam name="S">The structure type</typeparam>
    public interface IGroupM<S,T> : IGroupM<S>, IGroupLike<S,T>, IMonoidM<S,T>
        where S : IGroupM<S,T>, new()
    {
        
    }

    /// <summary>
    /// Characterizes an additive group structure
    /// </summary>
    /// <typeparam name="T">The type over which the structure is defind</typeparam>
    /// <typeparam name="S">The structure type</typeparam>
    public interface IGroupA<S,T> : IGroupA<S>, IGroupLike<S,T>, IMonoidA<S,T>
        where S : IGroupA<S,T>, new()
    {
        
    }
}