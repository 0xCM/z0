//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    static class SVValidatorDFactories
    {
        public static IVUnaryOpMatch128D<T> UnaryOpMatchD<T>(this IValidationContext context, W128 w, T t = default)
            where T : unmanaged
                => new SVUnaryValidator128D<T>(context);

        public static ISVUnaryOpMatch256D<T> UnaryOpMatchD<T>(this IValidationContext context, W256 w, T t = default)
            where T : unmanaged
                => new SVUnaryValidator256D<T>(context);

        public static ISVBinaryOpMatch128D<T> BinaryOpMatchD<T>(this IValidationContext context, W128 w, T t = default)
            where T : unmanaged
                => new SVBinaryOp128DApiComparer<T>(context);

        public static ISVBinaryOpMatch256D<T> BinaryOpMatchD<T>(this IValidationContext context, W256 w, T t = default)
            where T : unmanaged
                => new VBinaryValidator256D<T>(context);

        public static ISVShiftMatch128D<T> ShiftOpMatchD<T>(this IValidationContext context, W128 w, T t = default)
            where T : unmanaged
                => new SVShiftValidator128D<T>(context);

        public static IVShiftMatch256D<T> ShiftOpMatchD<T>(this IValidationContext context, W256 w, T t = default)
            where T : unmanaged
                => new SVShiftValidator256D<T>(context);

        public static ISVTernaryOpMatch128D<T> TernaryOpMatchD<T>(this IValidationContext context, W128 w, T t = default)
            where T : unmanaged
                => new SVTernaryValidator128D<T>(context);

        public static ISVTernaryOpMatch256D<T> TernaryOpMatchD<T>(this IValidationContext context, W256 w, T t = default)
            where T : unmanaged
                => new SVTernaryValidator256D<T>(context);
    }
}