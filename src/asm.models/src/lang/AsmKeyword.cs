//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct AsmLang
    {
        /// <summary>
        /// Represents a keyword in the asm grammar
        /// </summary>
        public readonly struct AsmKeyword
        {
            public readonly AsmKeywordCode Key;

            [MethodImpl(Inline)]
            public AsmKeyword(AsmKeywordCode key)
                => Key = key;

            [MethodImpl(Inline)]
            public static implicit operator AsmKeyword(AsmKeywordCode src)
                => new AsmKeyword(src);

            [MethodImpl(Inline)]
            public static implicit operator AsmKeywordCode(AsmKeyword src)
                => src.Key;
        }
    }
}