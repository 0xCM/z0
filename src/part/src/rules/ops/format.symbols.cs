//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Rules
    {
        [Op]
        public static string format(VarSymbol src)
            => format(VarContextKind.Workflow, src);

        [Op, Closures(Closure)]
        public static string format<T>(VarSymbol<T> src)
            => format(VarContextKind.Workflow, src);

        [Op]
        public static string format(VarContextKind vck, VarSymbol src)
            => string.Format(FormatPattern(vck), src.Name);

        [Op, Closures(Closure)]
        public static string format<T>(VarContextKind vck, VarSymbol<T> src)
            => string.Format(FormatPattern(vck), src.Name);

        [Op]
        public static VarSymbol combine(VarContextKind vck, VarSymbol a, VarSymbol b)
            => new VarSymbol(string.Format("{0}{1}", format(vck,a), format(vck, b)));

        [Op]
        public static VarSymbol combine<T>(VarContextKind vck, VarSymbol<T> a, VarSymbol<T> b)
            => new VarSymbol(string.Format("{0}{1}", format(vck,a), format(vck, b)));
    }
}