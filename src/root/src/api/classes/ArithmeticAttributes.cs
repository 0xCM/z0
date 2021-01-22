//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = ArithmeticApiClass;
    using A = OpKindAttribute;

    public sealed class AddAttribute : A { public AddAttribute(AsmClass asm = 0) : base(K.Add, asm) {} }

    public sealed class AddSAttribute : A { public AddSAttribute(AsmClass asm = 0) : base(K.AddS, asm) {} }

    public sealed class AddHAttribute : A { public AddHAttribute(AsmClass asm = 0) : base(K.AddH, asm) {} }

    public sealed class AddHSAttribute : A { public AddHSAttribute(AsmClass asm = 0) : base(K.AddHS, asm) {} }

    public sealed class SadAttribute : A { public SadAttribute(AsmClass asm = 0) : base(K.Sad, asm) {} }

    public sealed class SubAttribute : A { public SubAttribute(AsmClass asm = 0) : base(K.Sub, asm) {} }

    public sealed class SubHAttribute : A { public SubHAttribute(AsmClass asm = 0) : base(K.SubH, asm) {} }

    public sealed class SubHSAttribute : A { public SubHSAttribute(AsmClass asm = 0) : base(K.SubHS, asm) {} }

    public sealed class SubSAttribute : A { public SubSAttribute(AsmClass asm = 0) : base(K.SubS, asm) {} }

    public sealed class MulAttribute : A { public MulAttribute(AsmClass asm = 0) : base(K.Mul, asm) {} }

    public sealed class MulLoAttribute : A { public MulLoAttribute(AsmClass asm = 0) : base(K.MulLo, asm) {} }

    public sealed class MulHiAttribute : A { public MulHiAttribute(AsmClass asm = 0) : base(K.MulHi, asm) {} }

    public sealed class DivAttribute : A { public DivAttribute(AsmClass asm = 0) : base(K.Div, asm) {} }

    public sealed class ModAttribute : A { public ModAttribute(AsmClass asm = 0) : base(K.Mod, asm) {} }

    public sealed class ClampAttribute : A { public ClampAttribute(AsmClass asm = 0) : base(K.Clamp, asm) {} }

    public sealed class DistAttribute : A { public DistAttribute(AsmClass asm = 0) : base(K.Dist, asm) {} }

    public sealed class ClMulAttribute : A { public ClMulAttribute(AsmClass asm = 0) : base(K.ClMul, asm) {} }

    public sealed class DotAttribute : A { public DotAttribute(AsmClass asm = 0) : base(K.Dot, asm) {} }

    public sealed class IncAttribute : A { public IncAttribute(AsmClass asm = 0) : base(K.Inc, asm) {} }

    public sealed class DecAttribute : A { public DecAttribute(AsmClass asm = 0) : base(K.Dec, asm) {} }

    public sealed class NegateAttribute : A { public NegateAttribute(AsmClass asm = 0) : base(K.Negate, asm) {} }

    public sealed class AbsAttribute : A { public AbsAttribute(AsmClass asm = 0) : base(K.Abs, asm) {} }

    public sealed class SquareAttribute : A { public SquareAttribute(AsmClass asm = 0) : base(K.Square, asm) {} }

    public sealed class SqrtAttribute : A { public SqrtAttribute(AsmClass asm = 0) : base(K.Sqrt, asm) {} }

    public sealed class FmaAttribute : A { public FmaAttribute(AsmClass asm = 0) : base(K.Fma, asm) {} }

    public sealed class ModMulAttribute : A { public ModMulAttribute(AsmClass asm = 0) : base(K.ModMul, asm) {} }

    public sealed class DivModAttribute : A { public DivModAttribute(AsmClass asm = 0) : base(K.DivMod, asm) {} }

    public sealed class AvgzAttribute : A { public AvgzAttribute(AsmClass asm = 0) : base(K.Avgz, asm) {} }

    public sealed class AvgiAttribute : A { public AvgiAttribute(AsmClass asm = 0) : base(K.Avgi, asm) {} }

    public sealed class MaxAttribute : A { public MaxAttribute(AsmClass asm = 0) : base(K.Max, asm) {} }

    public sealed class MinAttribute : A { public MinAttribute(AsmClass asm = 0) : base(K.Min, asm) {} }

    public sealed class CeilAttribute : A { public CeilAttribute(AsmClass asm = 0) : base(K.Ceil, asm) {} }

    public sealed class FloorAttribute : A { public FloorAttribute(AsmClass asm = 0) : base(K.Floor, asm) {} }

    public sealed class RoundAttribute : A { public RoundAttribute(AsmClass asm = 0) : base(K.Round, asm) {} }

    public sealed class PowAttribute : A { public PowAttribute(AsmClass asm = 0) : base(K.Pow, asm) {} }

    public sealed class Log2Attribute : A { public Log2Attribute(AsmClass asm = 0) : base(K.Log2, asm) {} }
}