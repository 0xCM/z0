//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public class AsmThumbprints : WfService<AsmThumbprints>
    {
        const string Implication = " => ";

        public static AsmThumbprint define(AsmSigExpr sig, AsmOpCodeExpr opcode, AsmHexCode encoded)
            => new AsmThumbprint(sig, opcode, encoded);

        [Op]
        public static AsmThumbprintExpr expression(AsmSigExpr sig, AsmOpCodeExpr opcode, AsmHexCode encoded)
        {
            var tp = define(sig, opcode, encoded);
            return new AsmThumbprintExpr(string.Format("{0}{1}{2}", tp, Implication, encoded));
        }

        [Op]
        public static int cmp(in AsmThumbprint a, in AsmThumbprint b)
            => AsmSyntax.format(a).CompareTo(AsmSyntax.format(b));

        [Op]
        public static bool eq(in AsmThumbprint a, in AsmThumbprint b)
            => AsmSyntax.format(a).Equals(AsmSyntax.format(b));

        [Op]
        public static int cmp(in AsmThumbprintExpr a, in AsmThumbprintExpr b)
        {
            var e0 = a.Format().LeftOfFirst(Implication);
            var e1 = b.Format().LeftOfFirst(Implication);
            return e0.CompareTo(e1);
        }
   }
}