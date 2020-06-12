//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using K = ArithmeticKind;
    using I = IArithmeticKind;

    /// <summary>
    /// Characteries an arithmetic function classifier
    /// </summary>
    public interface IArithmeticKind : IOpKind, IOpKind<K>
    {
        /// <summary>
        /// The literal identifier that will be lifted to the type-level
        /// </summary>
        K Kind {get;}

        OpKindId IOpKind.KindId => (OpKindId)Kind;
    }    

    /// <summary>
    /// Characterizes a reified arithmetic function classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IArithmeticKind<F> : I, IOpKind<F,K>
        where F : unmanaged, I
    {
        OpKindId IOpKind.KindId => default(F).KindId;                
    }
    
    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric arithmetic operation classifier
    /// </summary>
    /// <typeparam name="F">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IArithmeticKind<F,T> : IArithmeticKind<F>
        where F : unmanaged, I
    {
        K I.Kind => default(F).Kind;

        /// <summary>
        /// The parametrically-identified numeric kind
        /// </summary>
        NumericKind NumericKind => NumericKinds.kind<T>();
    }
}