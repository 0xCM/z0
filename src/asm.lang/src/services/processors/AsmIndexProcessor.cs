//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public sealed class AsmIndexProcessor : AsciTextProcessor<AsmIndexProcessor,AsmIndex>
    {
        protected override Outcome<AsmIndex> Process(uint number, ReadOnlySpan<char> chars)
        {
            var outcome = AsmParser.parse(number, chars, out AsmIndex record);
            return outcome ? record : outcome;
        }
    }
}