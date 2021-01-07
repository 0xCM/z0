//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;
    using K = MemoryApiClass;
    using I = IMemoryApiKey;

    /// <summary>
    /// Characterizes a reified system operation classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    [Free]
    public interface IMemoryOpKind<F> : I, IApiKind<F,K>
        where F : unmanaged, I
    {
        ApiClass IApiKey.Id
            => default(F).Id;
    }

    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric system operation classifier
    /// </summary>
    /// <typeparam name="F">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    [Free]
    public interface IMemoryOpKind<F,T> : IMemoryOpKind<F>
        where F : unmanaged, I
    {
        K I.Kind
            => default(F).Kind;

        /// <summary>
        /// The parametrically-identified numeric kind
        /// </summary>
        NumericKind NumericKind
            => Numeric.kind<T>();
    }
}