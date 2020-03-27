//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public static class SFMatchServices
    {
        public static ISVValidatorD<T> Decomposer<T>(this ITestContext context)
            where T : unmanaged
             => new SVValidatorD<T>(context);

        public static ISVValidatorD Decompostions(this ITestContext context)
            => new SVValidatorD(ValidationContext.From(context));
            
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