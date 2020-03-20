//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;    
    using static ShiftOpKind;
    
    using A = OpKindAttribute;

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