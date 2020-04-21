//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Seed;

    partial class XTend
    {
        public static bool AcceptsParameter(this ApiBits src, NumericKind kind)
            => Identities.numeric(src.Id.TextComponents.Skip(1)).Contains(kind);

        public static IEnumerable<ApiBits> AcceptsParameters(this IEnumerable<ApiBits> src, NumericKind k1, NumericKind k2)
            => from code in src
                let kinds = Identities.numeric(code.Id.TextComponents.Skip(1))
                where kinds.Contains(k1) && kinds.Contains(k2)
                select code;

        public static IEnumerable<ApiBits> AcceptsParameter(this IEnumerable<ApiBits> src, NumericKind kind)
            => from code in src
                where code.AcceptsParameter(kind)
                select code;

    }
}