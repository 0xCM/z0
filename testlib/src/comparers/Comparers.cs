//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public static class OpComparers
    {   
        public static IUnaryOpComparer<T> define<T>(IComparisonContext context, Classes.UnaryOp<T> unary)
            where T : unmanaged
                => new UnaryOpComparer<T>(context);

        public static IBinaryOpComparer<T> define<T>(IComparisonContext context, Classes.BinaryOp<T> unary)
            where T : unmanaged
                => new BinaryOpComparer<T>(context);

        public static ITernaryOpComparer<T> define<T>(IComparisonContext context, Classes.TernaryOp<T> unary)
            where T : unmanaged
                => new TernaryOpComparer<T>(context);

        public static IBinaryPredicateComparer<T> define<T>(IComparisonContext context, Classes.BinaryPredicate<T> unary)
            where T : unmanaged
                => new BinaryPredicateComparer<T>(context);

    }

    public static class FuncComparers
    {
        public static IUnaryOpComparer<T> UnaryOpComparer<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new UnaryOpComparer<T>(context);

        public static IUnaryOpComparer<T> UnaryOpComparer<T>(this ITestContext context, bool xzero, T t = default)
            where T : unmanaged
                => new UnaryOpComparer<T>(context,xzero);

        public static IBinaryOpComparer<T> BinaryOpComparer<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new BinaryOpComparer<T>(context);

        public static IBinaryOpComparer<T> BinaryOpComparer<T>(this ITestContext context, bool xzero, T t = default)
            where T : unmanaged
            => new BinaryOpComparer<T>(context,xzero);

        public static ITernaryOpComparer<T> TernaryOpComparer<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new TernaryOpComparer<T>(context);

        public static ITernaryOpComparer<T> TernaryOpComparer<T>(this ITestContext context, bool xzero = false, T t = default)
            where T : unmanaged
                => new TernaryOpComparer<T>(context,xzero);

        public static IBinaryPredicateComparer<T> BinaryPredicateComparer<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new BinaryPredicateComparer<T>(context);

        public static ITernaryFuncComparer<T,T,T,bit> TernaryPredicateComparer<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new TernaryFuncComparer<T,T,T,bit>(context);
    }
}
