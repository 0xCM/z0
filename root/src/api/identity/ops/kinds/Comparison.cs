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
    using A = OpKindAttribute;


    /// <summary>
    /// Identifies comparison operator classes
    /// </summary>
    public enum ComparisonOpKindId : ulong
    {        
        /// <summary>
        /// The empty identity
        /// </summary>
        None = 0,
        
        /// <summary>
        /// Classifies a binary operator that returns true iff its operands are equal
        /// </summary>
        Eq = Id.Eq,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is strictly smaller than the left operand
        /// </summary>
        Lt = Id.Lt,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is smaller than or equal to the left operand
        /// </summary>
        LtEq = Id.LtEq,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is strictly greater than the left operand
        /// </summary>
        Gt  = Id.Gt,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is greater than or equal to the left operand
        /// </summary>
        GtEq = Id.GtEq,
        
        /// <summary>
        /// Classifies a binary operator that returns true iff its operands are not equal
        /// </summary>
        Neq = Id.Neq,
    }    

    public sealed class EqAttribute : A { public EqAttribute() : base(Eq) {} }

    public sealed class NeqAttribute : A { public NeqAttribute() : base(Neq) {} }

    public sealed class LtAttribute : A { public LtAttribute() : base(Lt) {} }

    public sealed class LtEqAttribute : A { public LtEqAttribute() : base(LtEq) {} }

    public sealed class GtAttribute : A { public GtAttribute() : base(Gt) {} }

    public sealed class GtEqAttribute : A { public GtEqAttribute() : base(GtEq) {} }

    public sealed class BetweenAttribute : A { public BetweenAttribute() : base(Between) {} }
}