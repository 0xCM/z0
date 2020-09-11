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

        ApiOpId IOpKind.KindId
            => (ApiOpId)Kind;
    }

    /// <summary>
    /// Characterizes a reified bitlogic operation classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IBitLogicKind<F> : I, IOpKind<F,K>
        where F : unmanaged, I
    {
        ApiOpId IOpKind.KindId
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
}