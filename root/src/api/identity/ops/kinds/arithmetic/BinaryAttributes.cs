//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static BinaryArithmeticKind;
    
    using A = OpKindAttribute;

    public sealed class AddAttribute : A { public AddAttribute() : base(Add) {} }

    public sealed class AddSAttribute : A { public AddSAttribute() : base(AddS) {} }

    public sealed class AddHAttribute : A { public AddHAttribute() : base(AddH) {} }

    public sealed class AddHSAttribute : A { public AddHSAttribute() : base(AddHS) {} }

    public sealed class SubAttribute : A { public SubAttribute() : base(Sub) {} }

    public sealed class SubHAttribute : A { public SubHAttribute() : base(SubH) {} }

    public sealed class MulAttribute : A { public MulAttribute() : base(Mul) {} }

    public sealed class DivAttribute : A { public DivAttribute() : base(Div) {} }
        
    public sealed class ModAttribute : A { public ModAttribute() : base(Mod) {} }

    public sealed class ClampAttribute : A { public ClampAttribute() : base(Clamp) {} }

    public sealed class DistanceAttribute : A { public DistanceAttribute() : base(Distance) {} }

    public sealed class DotAttribute : A { public DotAttribute() : base(Dot) {} }
}