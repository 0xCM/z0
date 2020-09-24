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
            public readonly AsmKeywordKey Key;

            [MethodImpl(Inline)]
            public AsmKeyword(AsmKeywordKey key)
                => Key = key;

            [MethodImpl(Inline)]
            public static implicit operator AsmKeyword(AsmKeywordKey src)
                => new AsmKeyword(src);

            [MethodImpl(Inline)]
            public static implicit operator AsmKeywordKey(AsmKeyword src)
                => src.Key;
        }
    }
}