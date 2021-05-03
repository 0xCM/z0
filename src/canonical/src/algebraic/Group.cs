//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes group operations over a type
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IGroupOps<T> : IInversionOps<T>, ISemigroupOps<T>
    {

    }

    public interface IGroupMOps<T> : IGroupOps<T>, IMonoidMOps<T>, InversionMOps<T>
    {

    }

    /// <summary>
    /// Characterizes additive/abelian group operations
    /// </summary>
    public interface IGroupAOps<T> : IGroupOps<T>, IMonoidAOps<T>, INegatableOps<T>
    {

    }

    public interface IGroupLike<T> : IInvertive<T>, IMonoid<T>
    {

    }

    public interface IGroupM<T> : IGroupLike<T>, IMonoidM<T>
    {

    }

    public interface IGroupA<S> : IGroupLike<S>, IMonoidA<S>
        where S : new()
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
    /// Characterizes an additive group structure
    /// </summary>
    /// <typeparam name="T">The type over which the structure is defind</typeparam>
    /// <typeparam name="S">The structure type</typeparam>
    public interface IGroupA<S,T> : IGroupA<S>, IGroupLike<S,T>, IMonoidA<S,T>
        where S : IGroupA<S,T>, new()
    {

    }
}