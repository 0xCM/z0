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


    public static class TypedIdentities
    {
        //Verifies the identity ~(x + 1) = ~ x - 1 holds for 64-bit bitvectors 
        
        public static IEnumerable<ComparisonExpr<T>> ScalarIdentities<T>()
            where T : unmanaged
                => items(AndOverOr<T>(), AndOverXOr<T>(), OrOverAnd<T>(), NotOverAnd<T>(), NotOverXOr<T>());

        public static IEnumerable<ComparisonExpr<Vector128<T>>> Vec128Identities<T>()
            where T : unmanaged
                => items(AndOverOr128<T>(), AndOverXOr128<T>(), OrOverAnd128<T>(), NotOverAnd128<T>(), NotOverXOr128<T>());

        public static IEnumerable<ComparisonExpr<Vector256<T>>> Vec256Identities<T>()
            where T : unmanaged
                => items(AndOverOr256<T>(), AndOverXOr256<T>(), OrOverAnd256<T>(), NotOverAnd256<T>(), NotOverXOr256<T>());

        public static ComparisonExpr<T> AndOverOr<T>()
            where T : unmanaged
                => BitwiseIdentities<T>.AndOverOr;

        public static ComparisonExpr<T> AndOverXOr<T>()
            where T : unmanaged
                => BitwiseIdentities<T>.AndOverXOr;

        public static ComparisonExpr<T> OrOverAnd<T>()
            where T : unmanaged
                => BitwiseIdentities<T>.OrOverAnd;
        public static ComparisonExpr<T> NotOverAnd<T>()
            where T : unmanaged
                => BitwiseIdentities<T>.NotOverAnd;
        
        public static ComparisonExpr<T> NotOverXOr<T>()
            where T : unmanaged
                => BitwiseIdentities<T>.NotOverXOr;

        public static ComparisonExpr<Vector128<T>> AndOverOr128<T>()
            where T : unmanaged
                => AndOverOr<Vector128<T>>();

        public static ComparisonExpr<Vector128<T>> AndOverXOr128<T>()
            where T : unmanaged
                => AndOverXOr<Vector128<T>>();

        public static ComparisonExpr<Vector128<T>> OrOverAnd128<T>()
            where T : unmanaged
                => OrOverAnd<Vector128<T>>();

        public static ComparisonExpr<Vector128<T>> NotOverAnd128<T>()
            where T : unmanaged
                => NotOverAnd<Vector128<T>>();
                
        public static ComparisonExpr<Vector128<T>> NotOverXOr128<T>()
            where T : unmanaged
                => NotOverXOr<Vector128<T>>();

        public static ComparisonExpr<Vector256<T>> AndOverOr256<T>()
            where T : unmanaged
                => AndOverOr<Vector256<T>>();

        public static ComparisonExpr<Vector256<T>> AndOverXOr256<T>()
            where T : unmanaged
                => AndOverXOr<Vector256<T>>();

        public static ComparisonExpr<Vector256<T>> OrOverAnd256<T>()
            where T : unmanaged
                => OrOverAnd<Vector256<T>>();

        public static ComparisonExpr<Vector256<T>> NotOverAnd256<T>()
            where T : unmanaged
                => NotOverAnd<Vector256<T>>();
                
        public static ComparisonExpr<Vector256<T>> NotOverXOr256<T>()
            where T : unmanaged
                => NotOverXOr<Vector256<T>>();

    }


}