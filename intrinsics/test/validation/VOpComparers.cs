//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    public static class VValidators
    {
        public static IVUnaryOpComparer128D<T> VUnaryOpComparer<T>(this ITestContext context, N128 w, T t = default)
            where T : unmanaged
                => new VUnaryValidator128D<T>(context);

        public static IVUnaryOpComparer256D<T> VUnaryOpComparer<T>(this ITestContext context, N256 w, T t = default)
            where T : unmanaged
                => new VUnaryValidator256D<T>(context);

        public static IVBinaryOpComparer128D<T> VBinaryOpComparer<T>(this ITestContext context, N128 w, T t = default)
            where T : unmanaged
                => new VBinaryValidator128D<T>(context);

        public static IVBinaryOpComparer256D<T> VBinaryOpComparer<T>(this ITestContext context, N256 w, T t = default)
            where T : unmanaged
                => new VBinaryValidator256D<T>(context);

        public static IVShiftOpComparer128D<T> VShiftOpComparer<T>(this ITestContext context, N128 w, T t = default)
            where T : unmanaged
                => new VShiftComparer128D<T>(context);

        public static IVShiftOpComparer256D<T> VShiftComparer<T>(this ITestContext context, N256 w, T t = default)
            where T : unmanaged
                => new VShiftValidator256D<T>(context);

        public static IVTernaryOpComparer128D<T> VTernaryOpComparer<T>(this ITestContext context, N128 w, T t = default)
            where T : unmanaged
                => new VTernaryValidator128D<T>(context);

        public static IVTernaryOpComparer256D<T> VTernaryOpComparer<T>(this ITestContext context, N256 w, T t = default)
            where T : unmanaged
                => new VTernaryValidator256D<T>(context);
    }
}