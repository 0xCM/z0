//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using A = OpKindAttribute;
    using K = BitShiftKind;

    public sealed class SllAttribute : A { public SllAttribute(object group = null) : base(K.Sll, group) {} }

    public sealed class SllvAttribute : A { public SllvAttribute(object group = null) : base(K.Sllv, group) {} }

    public sealed class SrlAttribute : A { public SrlAttribute(object group = null) : base(K.Srl, group) {} }

    public sealed class SrlvAttribute : A { public SrlvAttribute(object group = null) : base(K.Srlv, group) {} }

    public sealed class SalAttribute : A { public SalAttribute(object group = null) : base(K.Sal, group) {} }

    public sealed class SraAttribute : A { public SraAttribute(object group = null) : base(K.Sra, group) {} }

    public sealed class RotlAttribute : A { public RotlAttribute(object group = null) : base(K.Rotl, group) {} }
        
    public sealed class RotrAttribute : A { public RotrAttribute(object group = null) : base(K.Rotr, group) {} }

    public sealed class XorSlAttribute : A { public XorSlAttribute(object group = null) : base(K.XorSl, group) {} }

    public sealed class XorSrAttribute : A { public XorSrAttribute(object group = null) : base(K.XorSr, group) {} }

    public sealed class XorsAttribute : A { public XorsAttribute(object group = null) : base(K.Xors, group) {} }

    public sealed class BsllAttribute : A { public BsllAttribute(object group = null) : base(K.Bsll, group) {} }    

    public sealed class BsrlAttribute : A { public BsrlAttribute(object group = null) : base(K.Bsrl, group) {} }        

    public sealed class RotlxAttribute : A { public RotlxAttribute(object group = null) : base(K.Rotlx, group) {} }
        
    public sealed class RotrxAttribute : A { public RotrxAttribute(object group = null) : base(K.Rotrx, group) {} }

    public sealed class SllxAttribute : A { public SllxAttribute(object group = null) : base(K.Sllx, group) {} }
        
    public sealed class SrlxAttribute : A { public SrlxAttribute(object group = null) : base(K.Srlx, group) {} }

}