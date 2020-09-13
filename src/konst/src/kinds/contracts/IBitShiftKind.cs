//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a bitshift operation classifier
    /// </summary>
    public interface IBitShiftKind : IOpKind, IOpKind<BitShiftOpId>
    {
        BitShiftOpId Kind {get;}

        ApiKeyKind IOpKind.KindId
            => (ApiKeyKind)Kind;
    }

    /// <summary>
    /// Characterizes a reified bitlogic operation classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IBitShiftKind<F> : IBitShiftKind, IOpKind<F,BitShiftOpId>
        where F : unmanaged, IBitShiftKind
    {
        ApiKeyKind IOpKind.KindId
            => default(F).KindId;
    }

    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric bitshift operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IBitShiftKind<K,T> : IBitShiftKind<K>
        where K : unmanaged, IBitShiftKind
    {
        BitShiftOpId IBitShiftKind.Kind => default(K).Kind;

        /// <summary>
        /// The parametrically-identified numeric kind
        /// </summary>
        NumericKind NumericKind
            => NumericKinds.kind<T>();
    }
}