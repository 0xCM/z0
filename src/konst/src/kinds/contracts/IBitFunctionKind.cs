//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = BitFunctionOpId;
    using I = IBitFunctionKind;

    /// <summary>
    /// Characterizes a bitfunction classifier
    /// </summary>
    public interface IBitFunctionKind : IOpKind, IOpKind<K>
    {
        BitFunctionOpId Kind {get;}

        ApiOpId IOpKind.KindId
            => (ApiOpId)Kind;
    }

    /// <summary>
    /// Characterizes a reified bitfunction classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IBitFunctionKind<F> : I, IOpKind<F,K>
        where F : unmanaged, I
    {
        ApiOpId IOpKind.KindId
            => default(F).KindId;
    }

    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric bitfunction operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IBitFunctionKind<F,T> : IBitFunctionKind<F>
        where F : unmanaged, I
    {
        K I.Kind
            => default(F).Kind;
    }
}