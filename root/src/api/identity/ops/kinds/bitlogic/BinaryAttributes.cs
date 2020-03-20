//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;
    using static OpKindId;

    using A = OpKindAttribute;

    public sealed class AndAttribute : A { public AndAttribute() : base(And) {} }

    public sealed class CNonImplAttribute : A { public CNonImplAttribute() : base(CNonImpl) {} }

    public sealed class LProjectAttribute : A { public LProjectAttribute() : base(LProject) {} }

    public sealed class NonImplAttribute : A { public NonImplAttribute() : base(NonImpl) {} }

    public sealed class RProjectAttribute : A { public RProjectAttribute() : base(RProject) {} }

    public sealed class OrAttribute : A { public OrAttribute() : base(Or) {} }

    public sealed class XorAttribute : A { public XorAttribute() : base(Xor) {} }

    public sealed class NorAttribute : A { public NorAttribute() : base(Nor) {} }

    public sealed class XnorAttribute : A { public XnorAttribute() : base(Xnor) {} }

    public sealed class RNotAttribute : A { public RNotAttribute() : base(RNot) {} }

    public sealed class CImplAttribute : A { public CImplAttribute() : base(CImpl) {} }

    public sealed class NandAttribute : A { public NandAttribute() : base(Nand) {} }

    public sealed class TrueAttribute : A { public TrueAttribute() : base(BinaryTrue) {} }

    public sealed class ImplAttribute : A { public ImplAttribute() : base(Impl) {} }

    public sealed class LNotAttribute : A { public LNotAttribute() : base(LNot) {} }

}