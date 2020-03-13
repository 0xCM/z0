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

    using A = OpKindAttribute;
    using Id = OpKindId;

    /// <summary>
    /// Classifies bitwise shift operators
    /// </summary>
    public enum ShiftKind : ulong
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

    partial class ClassifierFormat
    {
       public static string Format(this ShiftKind kind)        
            => kind switch {
                ShiftKind.Sll => "<<",
                ShiftKind.Srl => ">>",
                ShiftKind.Rotl => "<<>",
                ShiftKind.Rotr => ">><",
                _ => kind.ToString()
            };

        public static string Format<S,T>(this ShiftKind kind, S arg1, T arg2)
            => $"{arg1} {kind.Format()} {arg2}"; 
    }
}