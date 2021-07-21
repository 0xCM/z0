//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes multiplicative monoidal operations
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IMonoidMOps<T> : ISemigroupMOps<T>, IUnitalOps<T>
    {

    }

    /// <summary>
    /// Characterizes additive monoidal operations
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IMonoidAOps<T> : ISemigroupAOps<T>, INullaryOps<T>
    {

    }

    public interface IMonoidM<T> : IMonoid<T>, ISemigroupM<T>, IUnital<T>
    {

    }

    public interface IMonoidA<S> : IMonoid<S>, ISemigroupA<S>, INullary<S>
        where S : new()
    {

    }

    /// <summary>
    /// Characterizes multiplicative monoidal structure
    /// </summary>
    /// <typeparam name="S">The classified structure</typeparam>
    /// <typeparam name="T">The underlying type</typeparam>
    public interface IMonoidM<S,T> : IMonoidM<T>
        where S : IMonoidM<S,T>, new()
    {

    }

    /// <summary>
    /// Characterizes additive monoidal structure
    /// </summary>
    /// <typeparam name="S">The classified structure</typeparam>
    /// <typeparam name="T">The underlying type</typeparam>
    public interface IMonoidA<S,T> :  IMonoidA<S>
        where S : IMonoidA<S,T>, new()
    {

    }
}