//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    using Id = OpKindId;

    /// <summary>
    /// Classifies bitwise shift operators
    /// </summary>
    public enum ShiftOpKindId : ulong
    {
        /// <summary>
        /// Classifies a logical left-shift
        /// </summary>
        Sll = Id.Sll,

        /// <summary>
        /// Classifies a logical right-shift
        /// </summary>
        Srl = Id.Srl,

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