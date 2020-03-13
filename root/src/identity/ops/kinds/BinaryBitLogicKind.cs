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

    using K = OpKindId;
    using A = OpKindAttribute;


    // ~ Binary bitlogic
    // ~ ----------------------------------------------------------------------

    public sealed class FalseAttribute : A { public FalseAttribute() : base(False) {} }

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

    public sealed class TrueAttribute : A { public TrueAttribute() : base(True) {} }

    public sealed class AddAttribute : A { public AddAttribute() : base(Add) {} }

    public sealed class ImplAttribute : A { public ImplAttribute() : base(Impl) {} }

    public sealed class LNotAttribute : A { public LNotAttribute() : base(LNot) {} }


    public sealed class NotAttribute : A { public NotAttribute() : base(Not) {} }

    public sealed class SelectAttribute : A { public SelectAttribute() : base(Select) {} }    

    public static partial class OpKinds
    {
        public readonly struct False : IOpKind<False> { public K Id => K.False;}

        public readonly struct And : IOpKind<And> { public K Id => K.And;}

        public readonly struct CNonImpl : IOpKind<CNonImpl> { public K Id => K.CNonImpl;}

        public readonly struct LProject : IOpKind<LProject> { public K Id => K.LProject;}

        public readonly struct NonImpl : IOpKind<NonImpl> { public K Id => K.NonImpl;}

    }
}