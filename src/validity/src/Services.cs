//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public static class Validity
    {


    }

    public static class ServiceFactory
    {
        public static ISFMatch<T,T> UnaryOpMatch<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new SFOpMatch1<T>(context);

        public static ISFMatch<T,T,T> BinaryOpMatch<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new SBinaryOpComparer<T>(context);

        public static ISFMatch<T,T,T> BinaryOpMatch<T>(this ITestContext context, bool xzero, T t = default)
            where T : unmanaged
            => new SBinaryOpComparer<T>(context,xzero);

        public static ISFMatch<T,T,T,T> TernaryOpMatch<T>(this ITestContext context, bool xzero = false, T t = default)
            where T : unmanaged
                => new SFOpMatch3<T>(context,xzero);

        public static ISFMatch<T,T,bit> BinaryPredicateMatch<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new SBinaryPredMatch<T>(context);

        public static ISFMatch<T,T,T,bit> TernaryPredicateComparer<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new STernaryPredMatch<T>(context);        
    }
}