//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = ComparisonApiKey;
    using I = IComparisonApiKey;

    /// <summary>
    /// Characterizes a bitshift operation classifier
    /// </summary>
    public interface IComparisonApiKey : IApiKey, IOpKind<K>
    {
        K Kind {get;}

        ApiKeyId IApiKey.Id
            => (ApiKeyId)Kind;
    }

    /// <summary>
    /// Characterizes a reified comparison operation classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IComparisonKind<F> : I, IOpKind<F,K>
        where F : unmanaged, I
    {
        ApiKeyId IApiKey.Id
            => default(F).Id;
    }

    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric comparison operation classifier
    /// </summary>
    /// <typeparam name="F">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IComparisonKind<F,T> : IComparisonKind<F>
        where F : unmanaged, I
    {
        K I.Kind => default(F).Kind;

        /// <summary>
        /// The parametrically-identified numeric kind
        /// </summary>
        NumericKind NumericKind
            => NumericKinds.kind<T>();
    }

    /// <summary>
    /// Characterizes a kind, numeric, and width-parametric comparison operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IComparisonKind<F,W,T> : IComparisonKind<F,T>
        where W : unmanaged, ITypeWidth
        where F : unmanaged, IComparisonApiKey
    {
        /// <summary>
        /// The parametrically-identified operand width
        /// </summary>
        TypeWidth OperandWidth => Widths.type<W>();
    }
}