//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = SystemApiKeyKind;
    using I = ISystemOpKind;

    /// <summary>
    /// Characterizes a system operation classifier
    /// </summary>
    public interface ISystemOpKind : IOpKind, IOpKind<K>
    {
        K Kind {get;}

        ApiKeyId IOpKind.KindId
            => (ApiKeyId)Kind;
    }

    /// <summary>
    /// Characterizes a reified system operation classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface ISystemOpKind<F> : I, IOpKind<F,K>
        where F : unmanaged, I
    {
        ApiKeyId IOpKind.KindId
            => default(F).KindId;
    }

    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric system operation classifier
    /// </summary>
    /// <typeparam name="F">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface ISystemOpKind<F,T> : ISystemOpKind<F>
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