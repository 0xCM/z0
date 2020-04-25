//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    public static class FormatComparison
    {        
        public static string Format<T>(Block128<T> x, Block128<T> y, Vector128<T> expect, Vector128<T> actual, Vector128<T> result)
            where T : unmanaged
        {
            var dst = text.build();
            dst.AppendLabeled("left", Chars.Colon, x.Format());
            dst.AppendLabeled("right", Chars.Colon, y.Format());
            dst.AppendLabeled("expect", Chars.Colon, expect.Format());
            dst.AppendLabeled("actual", Chars.Colon, actual.Format());
            dst.AppendLabeled("result", Chars.Colon, result.Format());
            return dst.ToString();
        }

        public static string Format<T>(Block256<T> x, Block256<T> y, Vector256<T> expect, Vector256<T> actual, Vector256<T> result)
            where T : unmanaged
        {
            var dst = text.build();
            dst.AppendLabeled("left", Chars.Colon, x.Format());
            dst.AppendLabeled("right", Chars.Colon, y.Format());
            dst.AppendLabeled("expect", Chars.Colon, expect.Format());
            dst.AppendLabeled("actual", Chars.Colon, actual.Format());
            dst.AppendLabeled("result", Chars.Colon, result.Format());
            return dst.ToString();
        }
    }
}