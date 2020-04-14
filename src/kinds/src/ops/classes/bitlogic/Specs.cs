//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using Id = OpKindId;

    /// <summary>
    /// Characterizes a bitlogic operation classifier
    /// </summary>
    public interface IBitLogicKind : IOpKind, IOpKind<BitLogicKind>
    {
        BitLogicKind Kind {get;}

        OpKindId IOpKind.KindId => (OpKindId)Kind;        
    }    

    /// <summary>
    /// Characterizes a reified bitlogic operation classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IBitLogicKind<F> : IBitLogicKind, IOpKind<F,BitLogicKind>
        where F : unmanaged, IBitLogicKind
    {
        OpKindId IOpKind.KindId => default(F).KindId;        
    }
    
    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric bitlogic operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IBitLogicKind<K,T> : IBitLogicKind<K>
        where K : unmanaged, IBitLogicKind
        where T : unmanaged
    {
        BitLogicKind IBitLogicKind.Kind => default(K).Kind;

        /// <summary>
        /// The parametrically-identified numeric kind
        /// </summary>
        NumericKind NumericKind => NumericKinds.kind<T>();
    }

    /// <summary>
    /// Characterizes a kind, numeric, and width-parametric bitlogic operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IBitLogicKind<K,W,T> : IBitLogicKind<K,T>
        where W : unmanaged, ITypeWidth
        where K : unmanaged, IBitLogicKind
        where T : unmanaged
    {
        /// <summary>
        /// The parametrically-identified operand width
        /// </summary>
        TypeWidth OperandWidth => Widths.type<W>();
    }
}