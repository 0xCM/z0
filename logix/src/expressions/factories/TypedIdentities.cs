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

    public static class TypedIdentities
    {
        //Verifies the identity ~(x + 1) = ~ x - 1 holds for 64-bit bitvectors 
        
        public static IEnumerable<TypedEqualityExpr<T>> ScalarIdentities<T>()
            where T : unmanaged
                => items(AndOverOr<T>(), AndOverXOr<T>(), OrOverAnd<T>(), NotOverAnd<T>(), NotOverXOr<T>());

        public static IEnumerable<TypedEqualityExpr<Vector128<T>>> Vec128Identities<T>()
            where T : unmanaged
                => items(AndOverOr128<T>(), AndOverXOr128<T>(), OrOverAnd128<T>(), NotOverAnd128<T>(), NotOverXOr128<T>());

        public static IEnumerable<TypedEqualityExpr<Vector256<T>>> Vec256Identities<T>()
            where T : unmanaged
                => items(AndOverOr256<T>(), AndOverXOr256<T>(), OrOverAnd256<T>(), NotOverAnd256<T>(), NotOverXOr256<T>());

        public static TypedEqualityExpr<T> AndOverOr<T>()
            where T : unmanaged
                => TypedIdentities<T>.AndOverOr;

        public static TypedEqualityExpr<T> AndOverXOr<T>()
            where T : unmanaged
                => TypedIdentities<T>.AndOverXOr;

        public static TypedEqualityExpr<T> OrOverAnd<T>()
            where T : unmanaged
                => TypedIdentities<T>.OrOverAnd;
        public static TypedEqualityExpr<T> NotOverAnd<T>()
            where T : unmanaged
                => TypedIdentities<T>.NotOverAnd;
        
        public static TypedEqualityExpr<T> NotOverXOr<T>()
            where T : unmanaged
                => TypedIdentities<T>.NotOverXOr;

        public static TypedEqualityExpr<Vector128<T>> AndOverOr128<T>()
            where T : unmanaged
                => AndOverOr<Vector128<T>>();

        public static TypedEqualityExpr<Vector128<T>> AndOverXOr128<T>()
            where T : unmanaged
                => AndOverXOr<Vector128<T>>();

        public static TypedEqualityExpr<Vector128<T>> OrOverAnd128<T>()
            where T : unmanaged
                => OrOverAnd<Vector128<T>>();

        public static TypedEqualityExpr<Vector128<T>> NotOverAnd128<T>()
            where T : unmanaged
                => NotOverAnd<Vector128<T>>();
                
        public static TypedEqualityExpr<Vector128<T>> NotOverXOr128<T>()
            where T : unmanaged
                => NotOverXOr<Vector128<T>>();

        public static TypedEqualityExpr<Vector256<T>> AndOverOr256<T>()
            where T : unmanaged
                => AndOverOr<Vector256<T>>();

        public static TypedEqualityExpr<Vector256<T>> AndOverXOr256<T>()
            where T : unmanaged
                => AndOverXOr<Vector256<T>>();

        public static TypedEqualityExpr<Vector256<T>> OrOverAnd256<T>()
            where T : unmanaged
                => OrOverAnd<Vector256<T>>();

        public static TypedEqualityExpr<Vector256<T>> NotOverAnd256<T>()
            where T : unmanaged
                => NotOverAnd<Vector256<T>>();
                
        public static TypedEqualityExpr<Vector256<T>> NotOverXOr256<T>()
            where T : unmanaged
                => NotOverXOr<Vector256<T>>();


    }

    internal static class TypedIdentities<T>
        where T : unmanaged
    {
        /// <summary>
        /// Specifies the identity and(a,or(b,c)) == or(and(a,b), and(a,c))
        /// </summary>
        public static TypedEqualityExpr<T> AndOverOr
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
        public static TypedEqualityExpr<T> AndOverXOr
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
        public static TypedEqualityExpr<T> OrOverAnd
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
        public static TypedEqualityExpr<T> NotOverAnd
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
        public static TypedEqualityExpr<T> NotOverXOr
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