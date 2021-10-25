//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using Z0.Expr;
        
    public class Not : OpExpr1<Not,LogicExprKind>, ILogicOp
    {
        public Not(IExpr a)
            : base(a)
        {
            
        }

        public override LogicExprKind Kind 
            => LogicExprKind.Not;

        public override Label OpName 
            => "not";

        public override Not Make(IExpr a)
            => new Not(a);
    }    
}