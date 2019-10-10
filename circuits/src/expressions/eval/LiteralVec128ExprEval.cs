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
        readonly struct LiteralVec128ExprEval<T> : IBitwiseExprEval<T, LiteralExpr<Vec128<T>>>
            where T : unmanaged
        {
            public static LiteralVec128ExprEval<T> TheOnly = new LiteralVec128ExprEval<T>();

            public LiteralExpr<Vec128<T>> Eval(BitOpKind op, LiteralExpr<Vec128<T>> lhs, LiteralExpr<Vec128<T>> rhs)
            {
                switch(op)
                {
                    case BitOpKind.And:
                        return literal(ginx.vand(lhs.Value,rhs.Value));
                    case BitOpKind.Or:
                        return literal(ginx.vor(lhs.Value,rhs.Value));
                    case BitOpKind.XOr:
                        return literal(ginx.vxor(lhs.Value,rhs.Value));
                    default:
                        throw new Exception($"{op} Unsupported");
                }
            }

            public LiteralExpr<Vec128<T>> Eval(BitOpKind op, LiteralExpr<Vec128<T>> operand)
            {
                switch(op)
                {
                    case BitOpKind.Not:
                        return literal(ginx.vflip(operand.Value));
                    case BitOpKind.Negate:
                        return literal(ginx.vnegate(operand.Value));
                    default:
                        throw new Exception($"{op} Unsupported");
                }
            }

            public LiteralExpr<Vec128<T>> Eval(BitOpKind op, LiteralExpr<Vec128<T>> lhs, uint rhs)
            {
                switch(op)
                {
                    case BitOpKind.Sll:
                        return literal(ginx.vsll(lhs.Value, (byte)rhs));
                    case BitOpKind.Srl:
                        return literal(ginx.vsrl(lhs.Value, (byte)rhs));
                    case BitOpKind.Rotl:
                        return literal(ginx.vrotl(lhs.Value, (byte)rhs));
                    case BitOpKind.Rotr:
                        return literal(ginx.vrotr(lhs.Value, (byte)rhs));
                    default:
                        throw new Exception($"{op} Unsupported");
                }
            }
        }



    }

}