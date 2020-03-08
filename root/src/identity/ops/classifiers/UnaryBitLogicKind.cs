//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;
    using K = UnaryBitLogicKind;

    /// <summary>
    /// Classifies unary logic operators
    /// </summary>
    public enum UnaryBitLogicKind : byte
    {
        /// <summary>
        /// The unary operator that always returns false
        /// </summary>
        False = 0b00,

        /// <summary>
        /// Logial NOT
        /// </summary>
        Not = 0b01,        

        /// <summary>
        /// The identity operator
        /// </summary>
        Identity = 0b10,
        
        /// <summary>
        /// The unary operator that always returns true
        /// </summary>
        True = 0b11,
    }


    partial class OpKinds
    {
        public readonly struct Not : IOpKind<Not,K> { public K Kind { [MethodImpl(Inline)] get => K.Not;}}
    }
}