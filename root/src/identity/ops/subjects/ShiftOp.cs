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

    using A = OpSubjectAttribute;
    using Id = OpKindId;

    /// <summary>
    /// Classifies bitwise shift operators
    /// </summary>
    public enum ShiftOpKindId : ulong
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
    public sealed class SllAttribute : A { public SllAttribute() : base(Sll) {} }

    public sealed class SrlAttribute : A { public SrlAttribute() : base(Srl) {} }

    public sealed class SalAttribute : A { public SalAttribute() : base(Sal) {} }

    public sealed class SarAttribute : A { public SarAttribute() : base(Sar) {} }

    public sealed class RotlAttribute : A { public RotlAttribute() : base(Rotl) {} }
        
    public sealed class RotrAttribute : A { public RotrAttribute() : base(Rotr) {} }

    public sealed class XorSlAttribute : A { public XorSlAttribute() : base(XorSl) {} }

    public sealed class XorSrAttribute : A { public XorSrAttribute() : base(XorSr) {} }

    public sealed class XorsAttribute : A { public XorsAttribute() : base(Xors) {} }
}