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

    /// <summary>
    /// Classifies bitwise shift operators
    /// </summary>
    public enum ShiftKind : byte
    {
        /// <summary>
        /// Classifies a logical left-shift
        /// </summary>
        Sll = 1,

        /// <summary>
        /// Classifies a logical right-shift
        /// </summary>
        Srl = 2,

        /// <summary>
        /// Classifies a left circular shift
        /// </summary>
        Rotl = 4,

        /// <summary>
        /// Classifies a right circular shift
        /// </summary>
        Rotr  = 8,
    }    

    public sealed class SllAttribute : A { public SllAttribute() : base(Sll) {} }

    public sealed class SrlAttribute : A { public SrlAttribute() : base(Srl) {} }

    public sealed class SalAttribute : A { public SalAttribute() : base(Sal) {} }

    public sealed class SarAttribute : A { public SarAttribute() : base(Sar) {} }

    public sealed class RotlAttribute : A { public RotlAttribute() : base(Rotl) {} }
        
    public sealed class RotrAttribute : A { public RotrAttribute() : base(Rotr) {} }


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