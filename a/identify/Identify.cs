//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Identify)]

namespace Z0.Parts
{        
    public sealed class Identify : Part<Identify>
    {

    }
}

namespace Z0
{
    using System;
    using System.Linq;

    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Core;

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public static partial class Identify
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        [MethodImpl(Inline)]
        public static Option<TypeIdentity> ToOption(this TypeIdentity src)
            => src.IsEmpty ? none<TypeIdentity>() : some(src);


    }

    public static partial class XIdentify
    {
        public static bool AcceptsParameter(this AsmCode src, NumericKind kind)
            => Identify.Numeric(src.Id.TextComponents.Skip(1)).Contains(kind);

        public static IEnumerable<AsmCode> AcceptsParameters(this IEnumerable<AsmCode> src, NumericKind k1, NumericKind k2)
            => from code in src
                let kinds = Identify.Numeric(code.Id.TextComponents.Skip(1))
                where kinds.Contains(k1) && kinds.Contains(k2)
                select code;

        public static IEnumerable<AsmCode> AcceptsParameter(this IEnumerable<AsmCode> src, NumericKind kind)
            => from code in src
                where code.AcceptsParameter(kind)
                select code;

        
    }


    public static partial class XTend
    {

    }
}
