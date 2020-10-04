//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;
    using K = SystemApiKey;
    using I = ISystemOpKind;

    /// <summary>
    /// Characterizes a system operation classifier
    /// </summary>
    public interface ISystemOpKind : IApiKey, IOpKind<K>
    {
        K Kind {get;}

        ApiOpId IApiKey.Id
            => (ApiOpId)Kind;
    }

    /// <summary>
    /// Characterizes a reified system operation classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface ISystemOpKind<F> : I, IOpKind<F,K>
        where F : unmanaged, I
    {
        ApiOpId IApiKey.Id
            => default(F).Id;
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