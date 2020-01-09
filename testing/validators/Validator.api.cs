//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public static class Validators
    {
        public static IUnaryValidator<T,T> UnaryValidator<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new UnaryValidator<T,T>(context);

        public static IUnaryValidator<T,T> UnaryValidator<T>(this ITestContext context, bool xzero, T t = default)
            where T : unmanaged
                => new UnaryValidator<T,T>(context,xzero);

        public static IBinaryValidator<T,T,T> BinaryValidator<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new BinaryValidator<T,T,T>(context);

        public static IBinaryValidator<T,T,T> BinaryValidator<T>(this ITestContext context, bool xzero, T t = default)
            where T : unmanaged
            => new BinaryValidator<T,T,T>(context,xzero);

        public static IBinaryValidator<T,T,bit> BinaryPredicateValidator<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new BinaryValidator<T,T,bit>(context);

        public static ITernaryValidator<T,T,T,T> TernaryValidator<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new TernaryValidator<T,T,T,T>(context);

        public static ITernaryValidator<T,T,T,bit> TernaryPredicateValidator<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new TernaryValidator<T,T,T,bit>(context);

        public static ITernaryValidator<T,T,T,T> TernaryValidator<T>(this ITestContext context, bool xzero = false, T t = default)
            where T : unmanaged
                => new TernaryValidator<T,T,T,T>(context,xzero);

        public static IVUnaryValidator128D<T> VUnaryValidator<T>(this ITestContext context, N128 w, T t = default)
            where T : unmanaged
                => new VUnaryValidator128D<T>(context);

        public static IVUnaryValidator256D<T> VUnaryValidator<T>(this ITestContext context, N256 w, T t = default)
            where T : unmanaged
                => new VUnaryValidator256D<T>(context);

        public static IVBinaryValidator128D<T> VBinaryValidator<T>(this ITestContext context, N128 w, T t = default)
            where T : unmanaged
                => new VBinaryValidator128D<T>(context);

        public static IVBinaryValidator256D<T> VBinaryValidator<T>(this ITestContext context, N256 w, T t = default)
            where T : unmanaged
                => new VBinaryValidator256D<T>(context);

        public static IVShiftValidator128D<T> VShiftValidator<T>(this ITestContext context, N128 w, T t = default)
            where T : unmanaged
                => new VShiftValidator128D<T>(context);

        public static IVShiftValidator256D<T> VShiftValidator<T>(this ITestContext context, N256 w, T t = default)
            where T : unmanaged
                => new VShiftValidator256D<T>(context);

        public static IVTernaryValidator128D<T> VTernaryValidator<T>(this ITestContext context, N128 w, T t = default)
            where T : unmanaged
                => new VTernaryValidator128D<T>(context);

        public static IVTernaryValidator256D<T> VTernaryValidator<T>(this ITestContext context, N256 w, T t = default)
            where T : unmanaged
                => new VTernaryValidator256D<T>(context);


    }
}
