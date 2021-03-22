//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Rules;
    using static Chars;

    public class AsmThumbprints : WfService<AsmThumbprints>
    {
        const string Implication = " => ";

        [Op]
        public static AsmThumbprintExpr expression(AsmSigExpr sig, AsmOpCodeExpr opcode, AsmHexCode encoded)
        {
            var lhs = string.Format("({0})<{1}>[{2}]", sig, opcode,  encoded.Size);
            var rhs = encoded.Format();
            return new AsmThumbprintExpr(string.Concat(lhs,Implication,rhs));
        }

        [Op]
        public static string format(AsmThumbprint src)
        {
            var lhs = string.Format("({0})<{1}>[{2}]", src.Sig, src.OpCode,  src.Encoded.Size);
            var rhs = src.Encoded.Format();
            return string.Concat(lhs,Implication,rhs);
        }

        [Op]
        public static int cmp(in AsmThumbprint a, in AsmThumbprint b)
            => format(a).CompareTo(format(b));

        [Op]
        public static bool eq(in AsmThumbprint a, in AsmThumbprint b)
            => format(a).Equals(format(b));

        [Op]
        public static int cmp(in AsmThumbprintExpr a, in AsmThumbprintExpr b)
        {
            var e0 = a.Format().LeftOfFirst(Implication);
            var e1 = b.Format().LeftOfFirst(Implication);
            return e0.CompareTo(e1);
        }
   }
}