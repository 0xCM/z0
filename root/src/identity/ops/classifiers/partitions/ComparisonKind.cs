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
    /// Classifies comparisons
    /// </summary>
    public enum ComparisonKind : byte
    {        
        /// <summary>
        /// Classifies a binary operator that returns true iff its operands are equal
        /// </summary>
        Eq = 1,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is strictly smaller than the left operand
        /// </summary>
        Lt = 2,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is smaller than or equal to the left operand
        /// </summary>
        LtEq = 3,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is strictly greater than the left operand
        /// </summary>
        Gt  = 4,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is greater than or equal to the left operand
        /// </summary>
        GtEq = 5,
        
        /// <summary>
        /// Classifies a binary operator that returns true iff its operands are not equal
        /// </summary>
        Neq = 6,
    }    


    public sealed class EqAttribute : A { public EqAttribute() : base(Eq) {} }

    public sealed class NeqAttribute : A { public NeqAttribute() : base(Neq) {} }

    public sealed class LtAttribute : A { public LtAttribute() : base(Lt) {} }

    public sealed class LtEqAttribute : A { public LtEqAttribute() : base(LtEq) {} }

    public sealed class GtAttribute : A { public GtAttribute() : base(Gt) {} }

    public sealed class GtEqAttribute : A { public GtEqAttribute() : base(GtEq) {} }

    public sealed class BetweenAttribute : A { public BetweenAttribute() : base(Between) {} }


    partial class ClassifierFormat
    {

        [MethodImpl(Inline)]
        public static string Format(this ComparisonKind kind)
            => kind.ToString().ToLower();


        [MethodImpl(Inline)]
        public static string Format<T>(this ComparisonKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";
    }
}