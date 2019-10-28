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
    using System.Runtime.Intrinsics;
    using static zfunc;

    using static TypedLogicSpec;


    internal static class TypedIdentities<T>
        where T : unmanaged
    {
        /// <summary>
        /// Specifies the identity and(a,or(b,c)) == or(and(a,b), and(a,c))
        /// </summary>
        public static ComparisonExpr<T> AndOverOr
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
        public static ComparisonExpr<T> AndOverXOr
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
        public static ComparisonExpr<T> OrOverAnd
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
        public static ComparisonExpr<T> NotOverAnd
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
        public static ComparisonExpr<T> NotOverXOr
        {
            get
            {                
                (var a, var b) = vars2;
                var lhs = not(xor(a,b));
                var rhs = xor(not(a),b);
                return equals(lhs,rhs,a,b);

            }
        }


        static (VariableExpr<T> a, VariableExpr<T> b) vars2
        {
            [MethodImpl(Inline)]
            get => (variable<T>('a'), variable<T>('b'));
        }

        static (VariableExpr<T> a, VariableExpr<T> b, VariableExpr<T> c) vars3
        {
            [MethodImpl(Inline)]
            get => (variable<T>('a'), variable<T>('b'), variable<T>('c'));
        }

    }

}