//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Characterizes a bitshift operation classifier
    /// </summary>
    public interface IBitShiftKind : IOpKind, IOpKind<BitShiftKind>
    {
        BitShiftKind Kind {get;}

        OpKindId IOpKind.KindId => (OpKindId)Kind;
    }    

    /// <summary>
    /// Characterizes a reified bitlogic operation classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IBitShiftKind<F> : IBitShiftKind, IOpKind<F,BitShiftKind>
        where F : unmanaged, IBitShiftKind
    {
        OpKindId IOpKind.KindId => default(F).KindId;                
    }
    
    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric bitshift operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IBitShiftKind<K,T> : IBitShiftKind<K>
        where K : unmanaged, IBitShiftKind
        where T : unmanaged
    {
        BitShiftKind IBitShiftKind.Kind => default(K).Kind;

        /// <summary>
        /// The parametrically-identified numeric kind
        /// </summary>
        NumericKind NumericKind => NumericKinds.kind<T>();
    }

    /// <summary>
    /// Characterizes a kind, numeric, and width-parametric bitshift operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IBitShiftKind<K,W,T> : IBitShiftKind<K,T>
        where W : unmanaged, ITypeWidth
        where K : unmanaged, IBitShiftKind
        where T : unmanaged
    {
        /// <summary>
        /// The parametrically-identified operand width
        /// </summary>
        TypeWidth OperandWidth => Widths.type<W>();

    }
}