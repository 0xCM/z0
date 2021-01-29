//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public partial class AsmTokenIndex
    {
        internal const int TokenCount = (int)AsmSigKeywordId.TokenCount;

        public readonly SemanticLookup<AsmSigKeywordId,string> Identifier;

        [MethodImpl(Inline), Op]
        public static AsmTokenIndex create()
        {
            var index = new AsmTokenIndex();


            return index;
        }

        [MethodImpl(Inline), Op]
        public ref readonly string identifier(AsmSigKeywordId kind)
            => ref Identifier[kind];

        [MethodImpl(Inline), Op]
        public string meaning(AsmSigKeywordId kind)
            => Meaning[(int)kind];

        [MethodImpl(Inline), Op]
        public string value(AsmSigKeywordId kind)
            => Value[(int)kind];

        [MethodImpl(Inline), Op]
        public TokenRecord model(AsmSigKeywordId kind)
            => Records[(int)kind];
    }
}