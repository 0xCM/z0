//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = ApiBitFunctionClass;
    using I = IBitFunctionApiKey;

    /// <summary>
    /// Characterizes a bitfunction classifier
    /// </summary>
    public interface IBitFunctionApiKey : IApiKey, IApiKind<K>
    {
        ApiBitFunctionClass Kind {get;}

        ApiClass IApiKey.Id
            => (ApiClass)Kind;
    }

    /// <summary>
    /// Characterizes a reified bitfunction classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IBitFunctionApiKey<F> : I, IApiKind<F,K>
        where F : unmanaged, I
    {
        ApiClass IApiKey.Id
            => default(F).Id;
    }

    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric bitfunction operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IBitFunctionApiKey<F,T> : IBitFunctionApiKey<F>
        where F : unmanaged, I
    {
        K I.Kind
            => default(F).Kind;
    }

    /// <summary>
    /// Characterizes a kind, numeric, and width-parametric bitfunction operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IBitFunctionApiKey<F,W,T> : IBitFunctionApiKey<F,T>
        where W : unmanaged, ITypeWidth
        where F : unmanaged, IBitFunctionApiKey
    {
        /// <summary>
        /// The parametrically-identified operand width
        /// </summary>
        TypeWidth OperandWidth => Widths.type<W>();
    }
}