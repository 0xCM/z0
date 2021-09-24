//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Root;
    using static VarContextKind;

    [ApiHost]
    public readonly struct ScriptVars
    {
        const NumericKind Closure = UnsignedInts;

        [Op]
        public static string format(VarSymbol src)
            => format(VarContextKind.Workflow, src);

        [Op, Closures(Closure)]
        public static string format<T>(VarSymbol<T> src)
            => format(Workflow, src);

        [Op]
        public static string format(VarContextKind vck, VarSymbol src)
            => string.Format(pattern(vck), src.Name);

        [Op, Closures(Closure)]
        public static string format<T>(VarContextKind vck, VarSymbol<T> src)
            => string.Format(pattern(vck), src.Name);

        [Op]
        public static VarSymbol combine(VarContextKind vck, VarSymbol a, VarSymbol b)
            => new VarSymbol(string.Format("{0}{1}", format(vck,a), format(vck, b)));

        [Op]
        public static VarSymbol combine<T>(VarContextKind vck, VarSymbol<T> a, VarSymbol<T> b)
            => new VarSymbol(string.Format("{0}{1}", format(vck,a), format(vck, b)));

        static string pattern(VarContextKind vck)
            => vck switch
            {
                CmdScript => "%{0}%",
                PsScript => "${0}",
                BashScript => "${0}",
                MsBuild => "$({0})",
                _ => "{0}"
            };
    }
}