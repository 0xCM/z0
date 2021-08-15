//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct AsmOperands
    {
        public readonly struct word : ISizedTarget<word>
        {
            public AsmAddress Target {get;}

            public AsmSizeKind SizeKind
                => AsmSizeKind.word;

            [MethodImpl(Inline)]
            public word(AsmAddress reg)
            {
                Target = reg;
            }

            [MethodImpl(Inline)]
            public static implicit operator word(AsmAddress reg)
                => new word(reg);
        }
    }
}