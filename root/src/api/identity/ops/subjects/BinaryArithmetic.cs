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
    /// Identifies binary arithmetic operators classes
    /// </summary>
    public enum BinaryArithmeticKindId : ulong
    {
        /// <summary>
        /// The empty identity
        /// </summary>
        None = 0,

        Add = Id.Add,

        Sub = Id.Sub,

        Mul = Id.Mul,

        Div = Id.Div,

        Mod = Id.Mod,

        Clamp = Id.Clamp,
    }    
    
    public sealed class SubAttribute : A { public SubAttribute() : base(Sub) {} }

    public sealed class MulAttribute : A { public MulAttribute() : base(Mul) {} }

    public sealed class DivAttribute : A { public DivAttribute() : base(Div) {} }
        
    public sealed class ModAttribute : A { public ModAttribute() : base(Mod) {} }

    public sealed class ClampAttribute : A { public ClampAttribute() : base(Clamp) {} }

    public sealed class DistanceAttribute : A { public DistanceAttribute() : base(Distance) {} }

    public sealed class DividesAttribute : A { public DividesAttribute() : base(Divides) {} }

    public sealed class DotAttribute : A { public DotAttribute() : base(Dot) {} }
}