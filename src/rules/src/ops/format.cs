//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Root;
    using static core;

    using System.Runtime.CompilerServices;

    partial struct Rules
    {
        public static string format<F,C>(Enclosed<F,C> rule)
        {
            var buffer = TextTools.buffer();
            render(rule,buffer);
            return buffer.Emit();
        }

        [Op]
        public static string format(IVar var, char assign)
            => string.Format("{0}{1}{2}", format(var.Symbol), assign, var.Value);

        [Op]
        public static string format(IVar var)
            => format(var, Chars.Eq);

        [Op]
        public static string format(VarContextKind vck, IVar var, char assign)
            => string.Format("{0}{1}{2}", format(vck, var.Symbol), assign, var.Value);

        [Op]
        public static string format(VarContextKind vck, IVar var)
            => format(vck,var, Chars.Eq);

        [Op]
        public static string format(VarSymbol src)
            => format(VarContextKind.Workflow, src);

        [Op, Closures(Closure)]
        public static string format<T>(VarSymbol<T> src)
            => format(VarContextKind.Workflow, src);

        [Op, Closures(Closure)]
        public static string format<T>(VarContextKind vck, VarSymbol<T> src)
            => string.Format(VarContextKinds.FormatPattern(vck), src.Name);

        [Op]
        public static string format(VarContextKind vck, VarSymbol src)
            => string.Format(VarContextKinds.FormatPattern(vck), src.Name);

        [Op]
        public static string format(in BitSection src)
            => string.Format("[{0}..{1}]", src.MinIndex, src.MaxIndex);
    }
}