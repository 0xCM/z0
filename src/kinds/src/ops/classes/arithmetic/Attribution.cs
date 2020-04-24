//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using K = ArithmeticKind;    
    using A = OpKindAttribute;

    public sealed class AddAttribute : A { public AddAttribute(object group = null) : base(K.Add, group) {} }

    public sealed class AddSAttribute : A { public AddSAttribute(object group = null) : base(K.AddS, group) {} }

    public sealed class AddHAttribute : A { public AddHAttribute(object group = null) : base(K.AddH, group) {} }

    public sealed class AddHSAttribute : A { public AddHSAttribute(object group = null) : base(K.AddHS, group) {} }

    public sealed class SadAttribute : A { public SadAttribute(object group = null) : base(K.Sad, group) {} }

    public sealed class SubAttribute : A { public SubAttribute(object group = null) : base(K.Sub, group) {} }

    public sealed class SubHAttribute : A { public SubHAttribute(object group = null) : base(K.SubH, group) {} }

    public sealed class SubHSAttribute : A { public SubHSAttribute(object group = null) : base(K.SubHS, group) {} }

    public sealed class SubSAttribute : A { public SubSAttribute(object group = null) : base(K.SubS, group) {} }

    public sealed class MulAttribute : A { public MulAttribute(object group = null) : base(K.Mul, group) {} }

    public sealed class MulLoAttribute : A { public MulLoAttribute(object group = null) : base(K.MulLo, group) {} }

    public sealed class MulHiAttribute : A { public MulHiAttribute(object group = null) : base(K.MulHi, group) {} }

    public sealed class DivAttribute : A { public DivAttribute(object group = null) : base(K.Div, group) {} }
        
    public sealed class ModAttribute : A { public ModAttribute(object group = null) : base(K.Mod, group) {} }

    public sealed class ClampAttribute : A { public ClampAttribute(object group = null) : base(K.Clamp, group) {} }

    public sealed class DistAttribute : A { public DistAttribute(object group = null) : base(K.Dist, group) {} }

    public sealed class ClMulAttribute : A { public ClMulAttribute(object group = null) : base(K.ClMul, group) {} }

    public sealed class DotAttribute : A { public DotAttribute(object group = null) : base(K.Dot, group) {} }

    public sealed class IncAttribute : A { public IncAttribute(object group = null) : base(K.Inc, group) {} }

    public sealed class DecAttribute : A { public DecAttribute(object group = null) : base(K.Dec, group) {} }

    public sealed class NegateAttribute : A { public NegateAttribute(object group = null) : base(K.Negate, group) {} }

    public sealed class AbsAttribute : A { public AbsAttribute(object group = null) : base(K.Abs, group) {} }

    public sealed class SquareAttribute : A { public SquareAttribute(object group = null) : base(K.Square, group) {} }

    public sealed class SqrtAttribute : A { public SqrtAttribute(object group = null) : base(K.Sqrt, group) {} }

    public sealed class FmaAttribute : A { public FmaAttribute(object group = null) : base(K.Fma, group) {} }

    public sealed class ModMulAttribute : A { public ModMulAttribute(object group = null) : base(K.ModMul, group) {} }

    public sealed class AvgzAttribute : A { public AvgzAttribute(object group = null) : base(K.Avgz, group) {} }

    public sealed class AvgiAttribute : A { public AvgiAttribute(object group = null) : base(K.Avgi, group) {} }

    public sealed class MaxAttribute : A { public MaxAttribute(object group = null) : base(K.Max, group) {} }

    public sealed class MinAttribute : A { public MinAttribute(object group = null) : base(K.Min, group) {} }

    public sealed class CeilAttribute : A { public CeilAttribute(object group = null) : base(K.Ceil, group) {} }

    public sealed class FloorAttribute : A { public FloorAttribute(object group = null) : base(K.Floor, group) {} }

    public sealed class RoundAttribute : A { public RoundAttribute(object group = null) : base(K.Round, group) {} }    

    public sealed class PowAttribute : A { public PowAttribute(object group = null) : base(K.Pow, group) {} }    
}