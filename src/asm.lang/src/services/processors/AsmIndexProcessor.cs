//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public sealed class AsmIndexProcessor : AsciTextProcessor<AsmIndex>
    {
        public static ITextProcessor<AsmIndex> create(IEventSink sink, Receiver<AsmIndex> receiver)
            => new AsmIndexProcessor(sink, receiver);

        AsmIndexProcessor(IEventSink sink, Receiver<AsmIndex> receiver)
            : base(sink, receiver)
        {

        }

        protected override Outcome<AsmIndex> Process(uint number, ReadOnlySpan<char> chars)
        {
            var outcome = AsmParser.parse(number, chars, out AsmIndex record);
            return outcome ? record : outcome;
        }
    }
}