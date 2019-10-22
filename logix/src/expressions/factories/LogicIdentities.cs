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
        /// <summary>
        /// Specifies the identity and(a,or(b,c)) == or(and(a,b), and(a,c))
        /// </summary>
        public static EqualityExpr AndOverOr
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
        public static EqualityExpr AndOverXOr
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
        public static EqualityExpr OrOverAnd
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
        public static EqualityExpr NotOverAnd
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
        public static EqualityExpr NotOverXOr
        {
            get
            {                
                (var a, var b) = vars2;
                var lhs = not(xor(a,b));
                var rhs = xor(not(a),b);
                return equals(lhs,rhs,a,b);

            }
        }


        static (VariableExpr a, VariableExpr b) vars2
        {
            [MethodImpl(Inline)]
            get => (variable('a'), variable('b'));
        }

        static (VariableExpr a, VariableExpr b, VariableExpr c) vars3
        {
            [MethodImpl(Inline)]
            get => (variable('a'), variable('b'), variable('c'));
        }

    }

}