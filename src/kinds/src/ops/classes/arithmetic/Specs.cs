//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    /// <summary>
    /// Characteries an arithmetic function classifier
    /// </summary>
    public interface IArithmeticKind : IOpKind, IOpKind<ArithmeticKind>
    {
        /// <summary>
        /// The literal identifier that will be lifted to the type-level
        /// </summary>
        ArithmeticKind Kind {get;}

        OpKindId IOpKind.KindId => (OpKindId)Kind;
    }    

    /// <summary>
    /// Characterizes a reified arithmetic function classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IArithmeticKind<F> : IArithmeticKind, IOpKind<F,ArithmeticKind>
        where F : unmanaged, IArithmeticKind
    {
        OpKindId IOpKind.KindId => default(F).KindId;                
    }
    
    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric arithmetic operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IArithmeticKind<K,T> : IArithmeticKind<K>
        where K : unmanaged, IArithmeticKind
        where T : unmanaged
    {

        ArithmeticKind IArithmeticKind.Kind => default(K).Kind;

        /// <summary>
        /// The parametrically-identified numeric kind
        /// </summary>
        NumericKind NumericKind => NumericKinds.kind<T>();
    }

    /// <summary>
    /// Characterizes a kind, numeric, and width-parametric arithmetic operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IArithmeticKind<K,W,T> : IArithmeticKind<K,T>
        where W : unmanaged, ITypeWidth
        where K : unmanaged, IArithmeticKind
        where T : unmanaged
    {
        /// <summary>
        /// The parametrically-identified operand width
        /// </summary>
        TypeWidth OperandWidth => Widths.type<W>();
    }
}