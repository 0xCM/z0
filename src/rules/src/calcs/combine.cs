//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static RuleModels;

    partial struct RuleCalcs
    {
        [Op]
        public static VarSymbol combine(VarContextKind vck, VarSymbol a, VarSymbol b)
            => new VarSymbol(string.Format("{0}{1}", format(vck,a), format(vck, b)));

        [Op]
        public static VarSymbol combine<T>(VarContextKind vck, VarSymbol<T> a, VarSymbol<T> b)
            => new VarSymbol(string.Format("{0}{1}", format(vck,a), format(vck, b)));
    }
}