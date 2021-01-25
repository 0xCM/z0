//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = ApiArithmeticClass;
    using I = IArithmeticApiKey;

    /// <summary>
    /// Characterizes an arithmetic function classifier
    /// </summary>
    public interface IArithmeticApiKey : IApiKey, IApiKind<K>
    {
        /// <summary>
        /// The literal identifier that will be lifted to the type-level
        /// </summary>
        K Kind {get;}

        NumericKind OperandKind
            => default;

        ApiClass IApiKey.Id
            => (ApiClass)Kind;
    }

    /// <summary>
    /// Characterizes a reified arithmetic function classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IArithmeticKind<F> : I, IApiKind<F,K>
        where F : unmanaged, I
    {
        ApiClass IApiKey.Id
            => default(F).Id;
    }

    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric arithmetic operation classifier
    /// </summary>
    /// <typeparam name="F">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IArithmeticKind<F,T> : IArithmeticKind<F>
        where F : unmanaged, I
    {
        K I.Kind
            => default(F).Kind;

        /// <summary>
        /// The parametrically-identified numeric kind
        /// </summary>
        NumericKind IArithmeticApiKey.OperandKind
            => Numeric.kind<T>();
    }

    /// <summary>
    /// Characterizes a kind, numeric, and width-parametric arithmetic operation classifier
    /// </summary>
    /// <typeparam name="F">The kind classifier type</typeparam>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IArithmeticKind<F,W,T> : IArithmeticKind<F,T>
        where W : unmanaged, ITypeWidth
        where F : unmanaged, IArithmeticApiKey
    {
        /// <summary>
        /// The parametrically-identified operand width
        /// </summary>
        TypeWidth OperandWidth
            => Widths.type<W>();
    }
}