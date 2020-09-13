//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;

    using K = BitLogicOpId;
    using I = IBitLogicKind;

    /// <summary>
    /// Characterizes a bitlogic operation classifier
    /// </summary>
    public interface IBitLogicKind : IOpKind, IOpKind<K>
    {
        K Kind {get;}

        ApiKeyKind IOpKind.KindId
            => (ApiKeyKind)Kind;
    }

    /// <summary>
    /// Characterizes a reified bitlogic operation classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IBitLogicKind<F> : I, IOpKind<F,K>
        where F : unmanaged, I
    {
        ApiKeyKind IOpKind.KindId
            => default(F).KindId;
    }

    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric bitlogic operation classifier
    /// </summary>
    /// <typeparam name="F">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IBitLogicKind<F,T> : IBitLogicKind<F>
        where F : unmanaged, I
    {
        BitLogicOpId I.Kind
            => default(F).Kind;

        /// <summary>
        /// The parametrically-identified numeric kind
        /// </summary>
        NumericKind NumericKind
            => NumericKinds.kind<T>();
    }

    /// <summary>
    /// Characterizes a kind, numeric, and width-parametric bitlogic operation classifier
    /// </summary>
    /// <typeparam name="F">The kind classifier type</typeparam>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IBitLogicKind<F,W,T> : IBitLogicKind<F,T>
        where W : unmanaged, ITypeWidth
        where F : unmanaged, IBitLogicKind
    {
        /// <summary>
        /// The parametrically-identified operand width
        /// </summary>
        TypeWidth OperandWidth => Widths.type<W>();
    }
}