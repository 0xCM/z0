//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using A = OpKindAttribute;    
    using K = BitLogicKind;

    public sealed class AndAttribute : A { public AndAttribute(object group = null) : base(K.And, group) {} }

    public sealed class CNonImplAttribute : A { public CNonImplAttribute(object group = null) : base(K.CNonImpl, group) {} }

    public sealed class LProjectAttribute : A { public LProjectAttribute(object group = null) : base(K.LProject, group) {} }

    public sealed class NonImplAttribute : A { public NonImplAttribute(object group = null) : base(K.NonImpl, group) {} }

    public sealed class RProjectAttribute : A { public RProjectAttribute(object group = null) : base(K.RProject, group) {} }

    public sealed class OrAttribute : A { public OrAttribute(object group = null) : base(K.Or, group) {} }

    public sealed class XorAttribute : A { public XorAttribute(object group = null) : base(K.Xor, group) {} }

    public sealed class NorAttribute : A { public NorAttribute(object group = null) : base(K.Nor, group) {} }

    public sealed class XnorAttribute : A { public XnorAttribute(object group = null) : base(K.Xnor, group) {} }

    public sealed class RNotAttribute : A { public RNotAttribute(object group = null) : base(K.RNot, group) {} }

    public sealed class CImplAttribute : A { public CImplAttribute(object group = null) : base(K.CImpl, group) {} }

    public sealed class NandAttribute : A { public NandAttribute(object group = null) : base(K.Nand, group) {} }

    public sealed class TrueAttribute : A { public TrueAttribute(object group = null) : base(K.True, group) {} }

    public sealed class ImplAttribute : A { public ImplAttribute(object group = null) : base(K.Impl, group) {} }

    public sealed class LNotAttribute : A { public LNotAttribute(object group = null) : base(K.LNot, group) {} }

    public sealed class FalseAttribute : A { public FalseAttribute(object group = null) : base(K.False, group) {} }

    public sealed class SelectAttribute : A { public SelectAttribute(object group = null) : base(K.Select, group) {} } 

    public sealed class NotAttribute : A { public NotAttribute(object group = null) : base(K.Not, group) {} }

    public sealed class XorNotAttribute : A { public XorNotAttribute(object group = null) : base(K.XorNot, group) {} }    
}