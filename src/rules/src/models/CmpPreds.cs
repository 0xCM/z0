//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Rules
    {
        [ApiHost("cmp.preds")]
        public readonly struct CmpPreds
        {
            const Z0.NumericKind Closure = Root.UnsignedInts;

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


            [Op, Closures(Closure)]
            public static string format<T>(CmpPred<T> src)
                => string.Format("{0}{1}{2}", src.A, symbol(src.Kind), src.B);

            [Op, Closures(Closure)]
            public static string format<T>(CmpEval<T> src)
                => string.Format("{0}:{1}", format(src.Source), src.Result ? "true" : "false");
        }
    }
}