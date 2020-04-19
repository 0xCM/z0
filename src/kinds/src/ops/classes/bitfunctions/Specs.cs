//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using K = BitFunctionKind;
    using I = IBitFunctionKind;

    /// <summary>
    /// Characteries a bitfunction classifier
    /// </summary>
    public interface IBitFunctionKind : IOpKind, IOpKind<K>
    {
        BitFunctionKind Kind {get;}

        OpKindId IOpKind.KindId => (OpKindId)Kind;
    }    

    /// <summary>
    /// Characterizes a reified bitfunction classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IBitFunctionKind<F> : I, IOpKind<F,K>
        where F : unmanaged, I
    {
        OpKindId IOpKind.KindId => default(F).KindId;                
    }
    
    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric bitfunction operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IBitFunctionKind<F,T> : IBitFunctionKind<F>
        where F : unmanaged, I
        where T : unmanaged
    {
        K I.Kind => default(F).Kind;
    }

    /// <summary>
    /// Characterizes a kind, numeric, and width-parametric bitfunction operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IBitFunctionKind<F,W,T> : IBitFunctionKind<F,T>
        where W : unmanaged, ITypeWidth
        where F : unmanaged, I
        where T : unmanaged
    {
        /// <summary>
        /// The parametrically-identified operand width
        /// </summary>
        TypeWidth OperandWidth => Widths.type<W>();
    }
}