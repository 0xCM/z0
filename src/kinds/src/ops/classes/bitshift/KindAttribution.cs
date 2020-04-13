//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using A = OpKindAttribute;
    using K = BitShiftKind;

    public sealed class SllAttribute : A { public SllAttribute(string group = null) : base(K.Sll, group) {} }

    public sealed class SrlAttribute : A { public SrlAttribute(string group = null) : base(K.Srl, group) {} }

    public sealed class SalAttribute : A { public SalAttribute(string group = null) : base(K.Sal, group) {} }

    public sealed class SraAttribute : A { public SraAttribute(string group = null) : base(K.Sra, group) {} }

    public sealed class RotlAttribute : A { public RotlAttribute(string group = null) : base(K.Rotl, group) {} }
        
    public sealed class RotrAttribute : A { public RotrAttribute(string group = null) : base(K.Rotr, group) {} }

    public sealed class XorSlAttribute : A { public XorSlAttribute(string group = null) : base(K.XorSl, group) {} }

    public sealed class XorSrAttribute : A { public XorSrAttribute(string group = null) : base(K.XorSr, group) {} }

    public sealed class XorsAttribute : A { public XorsAttribute(string group = null) : base(K.Xors, group) {} }
}