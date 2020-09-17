//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;

    using K = BooleanPredicateApiKeyKind;
    using I = IBooleanPredicateKind;

    /// <summary>
    /// Characterizes a bitfunction classifier
    /// </summary>
    public interface IBooleanPredicateKind : IOpKind, IOpKind<K>
    {
        K Kind {get;}

        ApiKeyId IOpKind.KindId
            => (ApiKeyId)Kind;
    }

    /// <summary>
    /// Characterizes a reified bitfunction classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IBooleanPredicateKind<F> : I, IOpKind<F,K>
        where F : unmanaged, I
    {
        ApiKeyId IOpKind.KindId
            => default(F).KindId;
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
            => NumericKinds.kind<T>();
    }
}