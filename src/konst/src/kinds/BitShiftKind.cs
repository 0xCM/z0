//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using Id = OpKindId;

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
        /// Classifies a variable logical left-shift
        /// </summary>
        Sllv = Id.Sllv,

        /// <summary>
        /// Classifies a logical right-shift
        /// </summary>
        Srl = Id.Srl,

        /// <summary>
        /// Classifies a variable logical right-shift
        /// </summary>
        Srlv = Id.Srlv,

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

        Bsrl = Id.Bsrl,

        Bsll = Id.Bsll,

        Rotrx = Id.Rotrx,

        Rotlx = Id.Rotlx,

        Sllx = Id.Sllx,

        Srlx = Id.Srlx,

    }    
}