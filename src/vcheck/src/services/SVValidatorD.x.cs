//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    static class SVValidatorDFactories
    {
        public static ICheckUnarySF128D<T> UnaryOpMatchD<T>(this ITestContext context, W128 w, T t = default)
            where T : unmanaged
                => new SVUnaryValidator128D<T>(context);

        public static ICheckUnarySF256D<T> UnaryOpMatchD<T>(this ITestContext context, W256 w, T t = default)
            where T : unmanaged
                => new SVUnaryValidator256D<T>(context);

        public static ICheckBinarySF128D<T> BinaryOpMatchD<T>(this ITestContext context, W128 w, T t = default)
            where T : unmanaged
                => new SVBinaryOp128DApiComparer<T>(context);

        public static ICheckBinarySF256D<T> BinaryOpMatchD<T>(this ITestContext context, W256 w, T t = default)
            where T : unmanaged
                => new VBinaryValidator256D<T>(context);

        public static ICheckShiftSF128D<T> ShiftOpMatchD<T>(this ITestContext context, W128 w, T t = default)
            where T : unmanaged
                => new SVShiftValidator128D<T>(context);

        public static ICheckShiftSF256D<T> ShiftOpMatchD<T>(this ITestContext context, W256 w, T t = default)
            where T : unmanaged
                => new SVShiftValidator256D<T>(context);

        public static ICheckTernarySF128D<T> TernaryOpMatchD<T>(this ITestContext context, W128 w, T t = default)
            where T : unmanaged
                => SVTernaryValidator128D<T>.Create(context);

        public static ISVTernaryOpMatch256D<T> TernaryOpMatchD<T>(this ITestContext context, W256 w, T t = default)
            where T : unmanaged
                => new SVTernaryValidator256D<T>(context);
    }
}