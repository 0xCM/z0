//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct AsmLang
    {
        /// <summary>
        /// Represents a keyword in the asm grammar
        /// </summary>
        public readonly struct Keyword : ISyntaxAtom<Keyword,KeywordCode>
        {
            public KeywordCode Code {get;}

            [MethodImpl(Inline)]
            public Keyword(KeywordCode key)
                => Code = key;

            [MethodImpl(Inline)]
            public static implicit operator Keyword(KeywordCode src)
                => new Keyword(src);

            [MethodImpl(Inline)]
            public static implicit operator KeywordCode(Keyword src)
                => src.Code;
        }
    }
}