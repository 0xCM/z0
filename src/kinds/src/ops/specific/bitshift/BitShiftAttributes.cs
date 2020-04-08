//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using A = OpKindAttribute;
    using K = BitShiftKind;

    public sealed class SllAttribute : A { public SllAttribute() : base(K.Sll) {} }

    public sealed class SrlAttribute : A { public SrlAttribute() : base(K.Srl) {} }

    public sealed class SalAttribute : A { public SalAttribute() : base(K.Sal) {} }

    public sealed class SarAttribute : A { public SarAttribute() : base(K.Sar) {} }

    public sealed class RotlAttribute : A { public RotlAttribute() : base(K.Rotl) {} }
        
    public sealed class RotrAttribute : A { public RotrAttribute() : base(K.Rotr) {} }

    public sealed class XorSlAttribute : A { public XorSlAttribute() : base(K.XorSl) {} }

    public sealed class XorSrAttribute : A { public XorSrAttribute() : base(K.XorSr) {} }

    public sealed class XorsAttribute : A { public XorsAttribute() : base(K.Xors) {} }
}