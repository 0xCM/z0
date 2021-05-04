//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial struct Rules
    {
        [Op]
        public static string resolve(VarContextKind vck, ScriptVar var)
            => string.Format(FormatPattern(vck), var.Value);

        [Op]
        public static string resolve<T>(VarContextKind vck, ScriptVar<T> var)
            => string.Format(FormatPattern(vck), var.Value);
    }
}