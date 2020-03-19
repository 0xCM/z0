//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;
    using static OpKindId;

    using Id = OpKindId;
    using A = OpSubjectAttribute;
    

    /// <summary>
    /// Classifies unary logic operators
    /// </summary>
    public enum UnaryBitLogicOpKind : byte
    {
        None = 0,
        
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

    public sealed class NotAttribute : A { public NotAttribute() : base(Not) {} }

    public interface IUnaryBitlogicKind : IBitLogicKind, IOpKind<UnaryBitLogicOpKind>
    {
        UnaryBitLogicOpKind IKind<UnaryBitLogicOpKind>.Class 
            => Enums.parse<UnaryBitLogicOpKind>(KindId.ToString()).ValueOrDefault();
    }    

    partial class OpKinds
    {
        public readonly struct Not : IUnaryBitlogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.Not;}}
    }
}