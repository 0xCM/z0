//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    
    using static Core;

    public class t_vformat : t_vinx<t_vformat>
    {   
        public static string DescribeShuffle<T>(Vector256<T> src, byte spec, Vector256<T> dst)
            where T : unmanaged
        {
            var xFmt = src.FormatHex();
            var specFmt = spec.ToBitString();
            var dstFmt = dst.FormatHex();

            var fmt = text.factory.Builder();
            var dataType = typeof(T).DisplayName();
            fmt.AppendLine(new string(Chars.Dash, 80));
            fmt.AppendLine($"shuffle256:Vec256<{dataType}> -> spec:byte -> {specFmt}");
            fmt.AppendLine(xFmt);
            fmt.AppendLine(dstFmt);
            return fmt.ToString();
        }

        public static string Describe2x128Perm<T>(Vector256<T> x, Vector256<T> y, byte spec, Vector256<T> dst)
            where T : unmanaged
        {
            var xFmt = x.FormatHex();
            var yFmt = y.FormatHex();
            var dstFmt = dst.Format();
            var specFmt = spec.ToBitString();
            var fmt = text.factory.Builder();
            var dataType = typeof(T).DisplayName();
            fmt.AppendLine(new string(Chars.Dash, 80));
            fmt.AppendLine($"permute2x128:Vec256<{dataType}> -> Vec256<{dataType}> -> {specFmt}");
            fmt.AppendLine(xFmt);
            fmt.AppendLine($"{yFmt}");
            fmt.AppendLine(dstFmt);
            return fmt.ToString();
        }
    }
}