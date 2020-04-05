//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    public static class FormatComparison
    {
        public static string Format<T>(Block128<T> x, Block128<T> y, Vector128<T> expect, Vector128<T> actual, Vector128<T> result)
            where T : unmanaged
        {
            var pad = 5;
            var dst = text.build();
            dst.AppendLabeled("left", Chars.Colon, x.FormatList(pad:pad));
            dst.AppendLabeled("right", Chars.Colon, y.FormatList(pad:pad));
            dst.AppendLabeled("expect", Chars.Colon, expect.FormatList(pad));
            dst.AppendLabeled("actual", Chars.Colon, actual.FormatList(pad));
            dst.AppendLabeled("result", Chars.Colon, result.FormatList(pad));
            return dst.ToString();
        }

        public static string Format<T>(Block256<T> x, Block256<T> y, Vector256<T> expect, Vector256<T> actual, Vector256<T> result)
            where T : unmanaged
        {
            var pad = 5;
            var dst = text.build();
            dst.AppendLabeled("left", Chars.Colon, x.FormatList(pad:pad));
            dst.AppendLabeled("right", Chars.Colon, y.FormatList(pad:pad));
            dst.AppendLabeled("expect", Chars.Colon, expect.Format(pad:pad));
            dst.AppendLabeled("actual", Chars.Colon, actual.Format(pad:pad));
            dst.AppendLabeled("result", Chars.Colon, result.Format(pad:pad));
            return dst.ToString();
        }
    }
}