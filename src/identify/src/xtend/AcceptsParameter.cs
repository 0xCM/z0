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
        public static bool AcceptsParameter(this LocatedBits src, NumericKind kind)
            => Identify.numeric(src.Id.TextComponents.Skip(1)).Contains(kind);

        public static IEnumerable<LocatedBits> AcceptsParameters(this IEnumerable<LocatedBits> src, NumericKind k1, NumericKind k2)
            => from code in src
                let kinds = Identify.numeric(code.Id.TextComponents.Skip(1))
                where kinds.Contains(k1) && kinds.Contains(k2)
                select code;

        public static IEnumerable<LocatedBits> AcceptsParameter(this IEnumerable<LocatedBits> src, NumericKind kind)
            => from code in src
                where code.AcceptsParameter(kind)
                select code;

    }
}