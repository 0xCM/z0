//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static memory;

    public readonly struct AsmSyntax
    {
        const string Implication = " => ";

        [Op]
        public static string format(AsmFormExpr src)
            => string.Format("({0})<{1}>", src.Sig, src.OpCode);

        public static uint render(AsmStatementSummaries src, ITextBuffer dst)
        {
            var values = src.Collected();
            var counter = 0u;
            for(var i=0; i<values.Length; i++)
            {
                ref readonly var value = ref skip(values,i);
                dst.AppendLineFormat("{0,-36} ; {1}", value.Statement, value.Thumbprint);
                counter++;
            }
            return counter;
        }

        [Op]
        public static string format(AsmThumbprint src)
        {
            var lhs = string.Format("({0})<{1}>[{2}]", src.Sig, src.OpCode,  src.Encoded.Size);
            var rhs = src.Encoded.Format();
            return string.Concat(lhs,Implication,rhs);
        }
    }
}