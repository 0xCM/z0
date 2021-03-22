//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static memory;

    public readonly partial struct AsmSyntax
    {
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
                dst.AppendLineFormat("{0} {1,-36} ; {2}", value.Offset, value.Statement, value.Thumbprint);
                counter++;
            }
            return counter;
        }
    }
}