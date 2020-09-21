//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;

    using K = MemoryApiKey;
    using I = IMemoryApiKey;

    /// <summary>
    /// Characterizes a system operation classifier
    /// </summary>
    public interface IMemoryApiKey : IApiKey, IOpKind<K>
    {
        K Kind {get;}

        ApiKeyId IApiKey.Id
            => (ApiKeyId)Kind;
    }

    /// <summary>
    /// Characterizes a reified system operation classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IMemoryOpKind<F> : I, IOpKind<F,K>
        where F : unmanaged, I
    {
        ApiKeyId IApiKey.Id
            => default(F).Id;
    }

    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric system operation classifier
    /// </summary>
    /// <typeparam name="F">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IMemoryOpKind<F,T> : IMemoryOpKind<F>
        where F : unmanaged, I
    {
        K I.Kind
            => default(F).Kind;

        /// <summary>
        /// The parametrically-identified numeric kind
        /// </summary>
        NumericKind NumericKind
            => NumericKinds.kind<T>();
    }
}