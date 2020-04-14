//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using K = ArithmeticKind;    
    using A = OpKindAttribute;

    public sealed class AddAttribute : A { public AddAttribute(string group = null) : base(K.Add, group) {} }

    public sealed class AddSAttribute : A { public AddSAttribute(string group = null) : base(K.AddS, group) {} }

    public sealed class AddHAttribute : A { public AddHAttribute(string group = null) : base(K.AddH, group) {} }

    public sealed class AddHSAttribute : A { public AddHSAttribute(string group = null) : base(K.AddHS, group) {} }

    public sealed class SadAttribute : A { public SadAttribute(string group = null) : base(K.Sad, group) {} }

    public sealed class SubAttribute : A { public SubAttribute(string group = null) : base(K.Sub, group) {} }

    public sealed class SubHAttribute : A { public SubHAttribute(string group = null) : base(K.SubH, group) {} }

    public sealed class SubHSAttribute : A { public SubHSAttribute(string group = null) : base(K.SubHS, group) {} }

    public sealed class SubSAttribute : A { public SubSAttribute(string group = null) : base(K.SubS, group) {} }

    public sealed class MulAttribute : A { public MulAttribute(string group = null) : base(K.Mul, group) {} }

    public sealed class MulLoAttribute : A { public MulLoAttribute(string group = null) : base(K.MulLo, group) {} }

    public sealed class MulHiAttribute : A { public MulHiAttribute(string group = null) : base(K.MulHi, group) {} }

    public sealed class DivAttribute : A { public DivAttribute(string group = null) : base(K.Div, group) {} }
        
    public sealed class ModAttribute : A { public ModAttribute(string group = null) : base(K.Mod, group) {} }

    public sealed class ClampAttribute : A { public ClampAttribute(string group = null) : base(K.Clamp, group) {} }

    public sealed class DistAttribute : A { public DistAttribute(string group = null) : base(K.Dist, group) {} }

    public sealed class ClMulAttribute : A { public ClMulAttribute(string group = null) : base(K.ClMul, group) {} }

    public sealed class DotAttribute : A { public DotAttribute(string group = null) : base(K.Dot, group) {} }

    public sealed class IncAttribute : A { public IncAttribute(string group = null) : base(K.Inc, group) {} }

    public sealed class DecAttribute : A { public DecAttribute(string group = null) : base(K.Dec, group) {} }

    public sealed class NegateAttribute : A { public NegateAttribute(string group = null) : base(K.Negate, group) {} }

    public sealed class AbsAttribute : A { public AbsAttribute(string group = null) : base(K.Abs, group) {} }

    public sealed class SquareAttribute : A { public SquareAttribute(string group = null) : base(K.Square, group) {} }

    public sealed class SqrtAttribute : A { public SqrtAttribute(string group = null) : base(K.Sqrt, group) {} }

    public sealed class FmaAttribute : A { public FmaAttribute(string group = null) : base(K.Fma, group) {} }

    public sealed class ModMulAttribute : A { public ModMulAttribute(string group = null) : base(K.ModMul, group) {} }

    public sealed class AvgzAttribute : A { public AvgzAttribute(string group = null) : base(K.Avgz, group) {} }

    public sealed class AvgiAttribute : A { public AvgiAttribute(string group = null) : base(K.Avgi, group) {} }

    public sealed class MaxAttribute : A { public MaxAttribute(string group = null) : base(K.Max, group) {} }

    public sealed class MinAttribute : A { public MinAttribute(string group = null) : base(K.Min, group) {} }
}