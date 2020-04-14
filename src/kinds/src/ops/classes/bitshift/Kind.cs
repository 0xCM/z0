//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using Id = OpKindId;

    public interface IBitShiftKind : IOpKind, IOpKind<BitShiftKind>
    {
        BitShiftKind Kind {get;}

        OpKindId IOpKind.KindId => (OpKindId)Kind;
    }    

    public interface IBitShiftKind<K> : IBitShiftKind, IOpKind<K,BitShiftKind>
        where K : unmanaged, IBitShiftKind
    {
        OpKindId IOpKind.KindId => default(K).KindId;                
    }
    
    public interface IBitShiftKind<K,T> : IBitShiftKind<K>
        where K : unmanaged, IBitShiftKind
        where T : unmanaged
    {
        BitShiftKind IBitShiftKind.Kind => default(K).Kind;
    }

    /// <summary>
    /// Classifies bitwise shift operators
    /// </summary>
    public enum BitShiftKind : ulong
    {    
        /// <summary>
        /// The empty identity
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifies a logical left-shift
        /// </summary>
        Sll = Id.Sll,

        /// <summary>
        /// Classifies a logical right-shift
        /// </summary>
        Srl = Id.Srl,

        /// <summary>
        /// Classifies an arithmetic left-shift
        /// </summary>
        Sal = Id.Sal,

        /// <summary>
        /// Classifies an arithmetic right-shift
        /// </summary>
        Sra = Id.Sra,

        /// <summary>
        /// Classifies a left circular shift
        /// </summary>
        Rotl = Id.Rotl,

        /// <summary>
        /// Classifies a right circular shift
        /// </summary>
        Rotr  = Id.Rotr,

        /// <summary>
        /// Classifies the composite operation a^(a << offset)
        /// </summary>
        XorSl = Id.XorSl,

        /// <summary>
        /// Classifies the composite operation a^(a >> offset)
        /// </summary>
        XorSr = Id.XorSr,

        /// <summary>
        /// Classifies the composite operation a ^ ((a << offset) ^ (a >> offset))
        /// </summary>
        Xors = Id.Xors,
    }    
}