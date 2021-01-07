//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using K = PredicateApiClass;
    using I = IPredicateApiKey;

    /// <summary>
    /// Characterizes a bitfunction classifier
    /// </summary>
    public interface IPredicateApiKey : IApiKey, IApiKind<K>
    {
        K Kind {get;}

        ApiClass IApiKey.Id
            => (ApiClass)Kind;
    }

    /// <summary>
    /// Characterizes a reified bitfunction classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IBooleanPredicateKind<F> : I, IApiKind<F,K>
        where F : unmanaged, I
    {
        ApiClass IApiKey.Id
            => default(F).Id;
    }

    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric boolean predicate operation classifier
    /// </summary>
    /// <typeparam name="F">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IBooleanPredicateKind<F,T> : IBooleanPredicateKind<F>
        where F : unmanaged, I
    {
        K I.Kind => default(F).Kind;

        /// <summary>
        /// The parametrically-identified numeric kind
        /// </summary>
        NumericKind NumericKind
            => Numeric.kind<T>();
    }
}