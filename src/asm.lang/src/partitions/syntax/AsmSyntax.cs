//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static memory;

    public readonly partial struct AsmSyntax
    {
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