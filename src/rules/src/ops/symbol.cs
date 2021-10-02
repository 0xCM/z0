//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct RuleModels
    {
        [Op]
        public static string symbol(CmpKind kind)
            => kind switch {
                CmpKind.EQ => CmpSymbol.EQ,
                CmpKind.NEQ => CmpSymbol.NEQ,
                CmpKind.GT => CmpSymbol.GT,
                CmpKind.GE => CmpSymbol.GE,
                CmpKind.LT => CmpSymbol.LT,
                CmpKind.LE => CmpSymbol.LE,
                _ => "?",
            };
    }
}