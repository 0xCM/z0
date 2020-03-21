//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public static class Validators
    {
        public static IUnaryFuncComparer<T,T> UnaryOpComparer<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new UnaryFuncComparer<T,T>(context);

        public static IUnaryFuncComparer<T,T> UnaryOpComparer<T>(this ITestContext context, bool xzero, T t = default)
            where T : unmanaged
                => new UnaryFuncComparer<T,T>(context,xzero);

        public static IBinaryFuncComparer<T,T,T> BinaryOpComparer<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new BinaryFuncComparer<T,T,T>(context);

        public static IBinaryFuncComparer<T,T,T> BinaryOpComparer<T>(this ITestContext context, bool xzero, T t = default)
            where T : unmanaged
            => new BinaryFuncComparer<T,T,T>(context,xzero);

        public static IBinaryFuncComparer<T,T,bit> BinaryPredicateComparer<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new BinaryFuncComparer<T,T,bit>(context);

        public static ITernaryFuncComparer<T,T,T,T> TernaryOpComparer<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new TernaryFuncComparer<T,T,T,T>(context);

        public static ITernaryFuncComparer<T,T,T,T> TernaryOpComparer<T>(this ITestContext context, bool xzero = false, T t = default)
            where T : unmanaged
                => new TernaryFuncComparer<T,T,T,T>(context,xzero);

        public static ITernaryFuncComparer<T,T,T,bit> TernaryPredicateComparer<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new TernaryFuncComparer<T,T,T,bit>(context);

    }
}
