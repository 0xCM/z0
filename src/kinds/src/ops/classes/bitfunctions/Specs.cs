//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using Id = OpKindId;

    /// <summary>
    /// Characteries a bitfunction classifier
    /// </summary>
    public interface IBitFunctionKind : IOpKind, IOpKind<BitFunctionKind>
    {
        BitFunctionKind Kind {get;}

        OpKindId IOpKind.KindId => (OpKindId)Kind;
    }    

    /// <summary>
    /// Characterizes a reified bitfunction classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IBitFunctionKind<F> : IBitFunctionKind, IOpKind<F,BitFunctionKind>
        where F : unmanaged, IBitFunctionKind
    {
        OpKindId IOpKind.KindId => default(F).KindId;                
    }
    
    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric bitfunction operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IBitFunctionKind<K,T> : IBitFunctionKind<K>
        where K : unmanaged, IBitFunctionKind
        where T : unmanaged
    {
        BitFunctionKind IBitFunctionKind.Kind => default(K).Kind;
    }

    /// <summary>
    /// Characterizes a kind, numeric, and width-parametric bitfunction operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IBitFunctionKind<K,W,T> : IBitFunctionKind<K,T>
        where W : unmanaged, ITypeWidth
        where K : unmanaged, IBitFunctionKind
        where T : unmanaged
    {
        /// <summary>
        /// The parametrically-identified operand width
        /// </summary>
        TypeWidth OperandWidth => Widths.type<W>();
    }
}