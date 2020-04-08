//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using K = BinaryArithmeticKind;    
    using A = OpKindAttribute;

    public sealed class AddAttribute : A { public AddAttribute() : base(K.Add) {} }

    public sealed class AddSAttribute : A { public AddSAttribute() : base(K.AddS) {} }

    public sealed class AddHAttribute : A { public AddHAttribute() : base(K.AddH) {} }

    public sealed class AddHSAttribute : A { public AddHSAttribute() : base(K.AddHS) {} }

    public sealed class SadAttribute : A { public SadAttribute() : base(K.Sad) {} }

    public sealed class SubAttribute : A { public SubAttribute() : base(K.Sub) {} }

    public sealed class SubHAttribute : A { public SubHAttribute() : base(K.SubH) {} }

    public sealed class SubHSAttribute : A { public SubHSAttribute() : base(K.SubHS) {} }

    public sealed class SubSAttribute : A { public SubSAttribute() : base(K.SubS) {} }

    public sealed class MulAttribute : A { public MulAttribute() : base(K.Mul) {} }

    public sealed class MulLoAttribute : A { public MulLoAttribute() : base(K.MulLo) {} }

    public sealed class MulHiAttribute : A { public MulHiAttribute() : base(K.MulHi) {} }

    public sealed class DivAttribute : A { public DivAttribute() : base(K.Div) {} }
        
    public sealed class ModAttribute : A { public ModAttribute() : base(K.Mod) {} }

    public sealed class ClampAttribute : A { public ClampAttribute() : base(K.Clamp) {} }

    public sealed class DistanceAttribute : A { public DistanceAttribute() : base(K.Distance) {} }

    public sealed class ClMulAttribute : A { public ClMulAttribute() : base(K.ClMul) {} }

    public sealed class DotAttribute : A { public DotAttribute() : base(K.Dot) {} }
}