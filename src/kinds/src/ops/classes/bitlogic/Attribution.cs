//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using A = OpKindAttribute;    
    using K = BitLogicKind;

    public sealed class AndAttribute : A { public AndAttribute(string group = null) : base(K.And, group) {} }

    public sealed class CNonImplAttribute : A { public CNonImplAttribute(string group = null) : base(K.CNonImpl, group) {} }

    public sealed class LProjectAttribute : A { public LProjectAttribute(string group = null) : base(K.LProject, group) {} }

    public sealed class NonImplAttribute : A { public NonImplAttribute(string group = null) : base(K.NonImpl, group) {} }

    public sealed class RProjectAttribute : A { public RProjectAttribute(string group = null) : base(K.RProject, group) {} }

    public sealed class OrAttribute : A { public OrAttribute(string group = null) : base(K.Or, group) {} }

    public sealed class XorAttribute : A { public XorAttribute(string group = null) : base(K.Xor, group) {} }

    public sealed class NorAttribute : A { public NorAttribute(string group = null) : base(K.Nor, group) {} }

    public sealed class XnorAttribute : A { public XnorAttribute(string group = null) : base(K.Xnor, group) {} }

    public sealed class RNotAttribute : A { public RNotAttribute(string group = null) : base(K.RNot, group) {} }

    public sealed class CImplAttribute : A { public CImplAttribute(string group = null) : base(K.CImpl, group) {} }

    public sealed class NandAttribute : A { public NandAttribute(string group = null) : base(K.Nand, group) {} }

    public sealed class TrueAttribute : A { public TrueAttribute(string group = null) : base(K.True, group) {} }

    public sealed class ImplAttribute : A { public ImplAttribute(string group = null) : base(K.Impl, group) {} }

    public sealed class LNotAttribute : A { public LNotAttribute(string group = null) : base(K.LNot, group) {} }

    public sealed class FalseAttribute : A { public FalseAttribute(string group = null) : base(K.False, group) {} }

    public sealed class SelectAttribute : A { public SelectAttribute(string group = null) : base(K.Select, group) {} } 

    public sealed class NotAttribute : A { public NotAttribute(string group = null) : base(K.Not, group) {} }
}