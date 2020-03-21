//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public static class VValidators
    {
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