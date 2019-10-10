//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    partial class Bitwise
    {
        readonly struct LiteralScalarExprEval<T> : IBitwiseExprEval<T,LiteralExpr<T>>
            where T : unmanaged
        {
            public static LiteralScalarExprEval<T> TheOnly = new LiteralScalarExprEval<T>();

            public LiteralExpr<T> Eval(BitOpKind op, LiteralExpr<T> lhs)
            {

                switch(op)
                {
                    case BitOpKind.Not:
                        return literal(gmath.flip(lhs.Value));
                    case BitOpKind.Negate:
                        return literal(gmath.negate(lhs.Value));
                    default:
                        throw new Exception($"{op} Unsupported");
                }
            }

            public LiteralExpr<T> Eval(BitOpKind op, LiteralExpr<T> lhs, uint rhs)
            {
                switch(op)
                {
                    case BitOpKind.Sll:
                        return literal(gmath.sll(lhs.Value, (int)rhs));
                    case BitOpKind.Srl:
                        return literal(gmath.srl(lhs.Value, (int)rhs));
                    case BitOpKind.Rotl:
                        return literal(gbits.rotl(lhs.Value, rhs));
                    case BitOpKind.Rotr:
                        return literal(gbits.rotr(lhs.Value, rhs));
                    default:
                        throw new Exception($"{op} Unsupported");
                }
            }

            public LiteralExpr<T> Eval(BitOpKind op, LiteralExpr<T> lhs, LiteralExpr<T> rhs)
            {
                switch(op)
                {
                    case BitOpKind.And:
                        return literal(gmath.and(lhs.Value,rhs.Value));
                    case BitOpKind.Or:
                        return literal(gmath.or(lhs.Value,rhs.Value));
                    case BitOpKind.XOr:
                        return literal(gmath.xor(lhs.Value,rhs.Value));
                    default:
                        throw new Exception($"{op} Unsupported");
                }
            }
        }
    }
}