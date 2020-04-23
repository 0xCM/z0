//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using I = ICanonicalKind;
    using K = CanonicalKind;

    public interface ICanonicalKind : IOpKind, IOpKind<K>
    {
        K Kind {get;}

        OpKindId IOpKind.KindId => (OpKindId)Kind;
    }    

    public interface ICanonicalKind<F> : I, IOpKind<F,K>
        where F : unmanaged, I
    {
        OpKindId IOpKind.KindId => default(F).KindId;                
    }
    
    public interface ICanonicalKind<F,T> : ICanonicalKind<F>
        where F : unmanaged, I
    {
        K I.Kind => default(F).Kind;
    }

    /// <summary>
    /// Characterizes a kind, numeric, and width-parametric canonical operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface ICanonicalKind<F,W,T> : ICanonicalKind<F,T>
        where W : unmanaged, ITypeWidth
        where F : unmanaged, I
    {
        /// <summary>
        /// The parametrically-identified operand width
        /// </summary>
        TypeWidth OperandWidth => Widths.type<W>();
    }

}