//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct ApiSummaryReport
    {
        public const string RenderPattern = "| {0,-16} | {1,-64} | {2,16} | {3, -64} | {4}";

        public static ReadOnlySpan<byte> RenderWidths => new byte[]{16,64,16,64,32};

        public static string format(in ApiSummaryInfo src)
            => string.Format(RenderPattern, src.Address, src.Uri, src.Genericity, src.Sig, src.Metadata);
    }
}