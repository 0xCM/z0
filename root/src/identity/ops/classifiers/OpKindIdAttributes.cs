//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using static OpKindId;

    using S = SpecificOpAttribute;


    public class IdentityAttribute : S { public IdentityAttribute() : base(Identity) {} }


    // ~ Binary Bitwise
    // ~ ----------------------------------------------------------------------

    public class FalseAttribute : S { public FalseAttribute() : base(False) {} }

    public class AndAttribute : S { public AndAttribute() : base(And) {} }

    public class CNonImplAttribute : S { public CNonImplAttribute() : base(CNonImpl) {} }

    public class LProjectAttribute : S { public LProjectAttribute() : base(LProject) {} }

    public class NonImplAttribute : S { public NonImplAttribute() : base(NonImpl) {} }

    public class RProjectAttribute : S { public RProjectAttribute() : base(RProject) {} }

    public class OrAttribute : S { public OrAttribute() : base(Or) {} }

    public class XorAttribute : S { public XorAttribute() : base(Xor) {} }

    public class NorAttribute : S { public NorAttribute() : base(Nor) {} }

    public class XnorAttribute : S { public XnorAttribute() : base(Xnor) {} }

    public class RNotAttribute : S { public RNotAttribute() : base(RNot) {} }

    public class CImplAttribute : S { public CImplAttribute() : base(CImpl) {} }

    public class NandAttribute : S { public NandAttribute() : base(Nand) {} }

    public class TrueAttribute : S { public TrueAttribute() : base(True) {} }

    public class AddAttribute : S { public AddAttribute() : base(Add) {} }

    public class ImplAttribute : S { public ImplAttribute() : base(Impl) {} }

    public class LNotAttribute : S { public LNotAttribute() : base(LNot) {} }

    // ~ Unary Bitwise
    // ~ ----------------------------------------------------------------------

    public class NotAttribute : S { public NotAttribute() : base(Not) {} }


    // ~ Ternary Bitwise
    // ~ ----------------------------------------------------------------------

    public class SelectAttribute : S { public SelectAttribute() : base(Select) {} }


    // ~ Unary Arithmetic
    // ~ ----------------------------------------------------------------------
    public class IncAttribute : S { public IncAttribute() : base(Inc) {} }

    public class DecAttribute : S { public DecAttribute() : base(Dec) {} }

    public class NegateAttribute : S { public NegateAttribute() : base(Negate) {} }

    public class AbsAttribute : S { public AbsAttribute() : base(Abs) {} }

    public class SquareAttribute : S { public SquareAttribute() : base(Square) {} }

    public class SqrtAttribute : S { public SqrtAttribute() : base(Sqrt) {} }

    // ~ Binary Arithmetic
    // ~ ----------------------------------------------------------------------

    public class SubAttribute : S { public SubAttribute() : base(Sub) {} }

    public class MulAttribute : S { public MulAttribute() : base(Mul) {} }

    public class DivAttribute : S { public DivAttribute() : base(Div) {} }
        
    public class ModAttribute : S { public ModAttribute() : base(Mod) {} }

    // ~ Shifts
    // ~ ----------------------------------------------------------------------

    public class SllAttribute : S { public SllAttribute() : base(Sll) {} }

    public class SrlAttribute : S { public SrlAttribute() : base(Srl) {} }

    public class SalAttribute : S { public SalAttribute() : base(Sal) {} }

    public class SarAttribute : S { public SarAttribute() : base(Sar) {} }

    public class RotlAttribute : S { public RotlAttribute() : base(Rotl) {} }
        
    public class RotrAttribute : S { public RotrAttribute() : base(Rotr) {} }

    // ~ Predicate
    // ~ ----------------------------------------------------------------------
    
    public class PredAttribute : S { public PredAttribute() : base(Pred) {} }

    // ~ Comparison
    // ~ ----------------------------------------------------------------------

    public class EqAttribute : S { public EqAttribute() : base(Eq) {} }

    public class NeqAttribute : S { public NeqAttribute() : base(Neq) {} }

    public class LtAttribute : S { public LtAttribute() : base(Lt) {} }

    public class LtEqAttribute : S { public LtEqAttribute() : base(LtEq) {} }

    public class GtAttribute : S { public GtAttribute() : base(Gt) {} }

    public class GtEqAttribute : S { public GtEqAttribute() : base(GtEq) {} }

    public class BetweenAttribute : S { public BetweenAttribute() : base(Between) {} }


}