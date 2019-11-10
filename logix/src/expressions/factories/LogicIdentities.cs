//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zfunc;

    using static BitLogicSpec;

    public static class LogicIdentities
    {
        public static IEnumerable<ComparisonExpr> All
            => items(AndOverOr, AndOverXOr, OrOverAnd, NotOverAnd, NotOverXOr);

        /// <summary>
        /// Specifies the identity and(a,or(b,c)) == or(and(a,b), and(a,c))
        /// </summary>
        public static ComparisonExpr AndOverOr
        {
            get
            {
                (var a, var b, var c) = vars3;             
                var lhs = and(a, or(b,c));
                var rhs = or(and(a,b), and(a,c));
                return equals(lhs,rhs, a,b,c);
            }
        }

        /// <summary>
        /// Specifies the identity and(a,xor(b,c)) == xor(and(a,b), and(a,c))
        /// </summary>
        public static ComparisonExpr AndOverXOr
        {
            get
            {
                (var a, var b, var c) = vars3;             
                var lhs = and(a, xor(b,c));
                var rhs = xor(and(a,b), and(a,c));
                return equals(lhs,rhs, a,b,c);

            }
        }

        /// <summary>
        /// Specifies the identity or(a,and(b,c)) == and(or(a,b), or(a,c))
        /// </summary>
        public static ComparisonExpr OrOverAnd
        {
            get
            {
                (var a, var b, var c) = vars3;             
                var lhs = and(a, or(b,c));
                var rhs = or(and(a,b), and(a,c));
                return equals(lhs, rhs, a, b, c);

            }
        }
        
        /// <summary>
        /// Specifies the identity not(and(a,b)) == or(not(x),not(y))
        /// </summary>
        public static ComparisonExpr NotOverAnd
        {
            get
            {
                (var a, var b) = vars2;
                var lhs = not(and(a,b));
                var rhs = or(not(a), not(b));
                return equals(lhs,rhs,a,b);

            }
        }

        /// <summary>
        /// Specifies the identity not(xor(a,b)) == xor(not(x),y)
        /// </summary>
        public static ComparisonExpr NotOverXOr
        {
            get
            {                
                (var a, var b) = vars2;
                var lhs = not(xor(a,b));
                var rhs = xor(not(a),b);
                return equals(lhs,rhs,a,b);

            }
        }

        static (LogicVariable a, LogicVariable b) vars2
        {
            [MethodImpl(Inline)]
            get => (lvar('a'), lvar('b'));
        }

        static (LogicVariable a, LogicVariable b, LogicVariable c) vars3
        {
            [MethodImpl(Inline)]
            get => (lvar('a'), lvar('b'), lvar('c'));
        }
    }
}