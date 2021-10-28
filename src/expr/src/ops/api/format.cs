//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ops
{
    using RFM = SyntaxPatterns;

    partial struct scalars
    {
        [Op, Closures(Closure)]
        internal static string format<T>(in CmpPred<T> src)
            where T : IExpr
                => string.Format(RFM.PackedSlots3, src.A, symbol(src.Kind), src.B);

        [Op]
        internal static string symbol(CmpPredKind kind)
            => kind switch {
                CmpPredKind.EQ => CmpPredSymbols.EQ,
                CmpPredKind.NEQ => CmpPredSymbols.NEQ,
                CmpPredKind.GT => CmpPredSymbols.GT,
                CmpPredKind.GE => CmpPredSymbols.GE,
                CmpPredKind.LT => CmpPredSymbols.LT,
                CmpPredKind.LE => CmpPredSymbols.LE,
                _ => "?",
            };
    }
}