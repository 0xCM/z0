//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a bitshift operation classifier
    /// </summary>
    public interface IBitShiftApiKey : IApiKey, IOpKind<BitShiftApiKey>
    {
        BitShiftApiKey Kind {get;}

        ApiOpId IApiKey.Id
            => (ApiOpId)Kind;
    }

    /// <summary>
    /// Characterizes a reified bitlogic operation classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IBitShiftApiKey<F> : IBitShiftApiKey, IOpKind<F,BitShiftApiKey>
        where F : unmanaged, IBitShiftApiKey
    {
        ApiOpId IApiKey.Id
            => default(F).Id;
    }

    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric bitshift operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IBitShiftApiKey<K,T> : IBitShiftApiKey<K>
        where K : unmanaged, IBitShiftApiKey
    {
        BitShiftApiKey IBitShiftApiKey.Kind
            => default(K).Kind;

        /// <summary>
        /// The parametrically-identified numeric kind
        /// </summary>
        NumericKind NumericKind
            => NumericKinds.kind<T>();
    }

    /// <summary>
    /// Characterizes a kind, numeric, and width-parametric bitshift operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IBitShiftApiKey<K,W,T> : IBitShiftApiKey<K,T>
        where W : unmanaged, ITypeWidth
        where K : unmanaged, IBitShiftApiKey
    {
        /// <summary>
        /// The parametrically-identified operand width
        /// </summary>
        TypeWidth OperandWidth
            => Widths.type<W>();
    }
}