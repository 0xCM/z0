//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Represents a keyword in the asm grammar
    /// </summary>
    public readonly struct AsmKeyword : ISyntaxAtom<AsmKeyword,AsmKeywordCode>
    {
        public AsmKeywordCode Code {get;}

        [MethodImpl(Inline)]
        public AsmKeyword(AsmKeywordCode key)
            => Code = key;

        [MethodImpl(Inline)]
        public static implicit operator AsmKeyword(AsmKeywordCode src)
            => new AsmKeyword(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmKeywordCode(AsmKeyword src)
            => src.Code;
    }
}