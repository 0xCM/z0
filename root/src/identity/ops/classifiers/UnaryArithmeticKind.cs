//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    using K = UnaryArithmeticKind;

    /// <summary>
    /// Classifies unary arithmetic operators
    /// </summary>
    public enum UnaryArithmeticKind : byte
    {
        Inc = 1,

        Dec = 2,

        Negate = 3,
    }    

    partial class OpKinds
    {
        public readonly struct Inc : IOpKind<Inc,K> { public K Kind { [MethodImpl(Inline)] get => K.Inc;}}        
        
        public readonly struct Dec : IOpKind<Dec,K> { public K Kind { [MethodImpl(Inline)] get => K.Dec;}}        

        public readonly struct Negate : IOpKind<Negate,K> { public K Kind { [MethodImpl(Inline)] get => K.Negate;}}
    }
}