//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly partial struct AsmTokens
    {
        [MethodImpl(Inline), Op]
        public static AsmTokenLookup lookup(in AsmTokenIndex index)
            => new AsmTokenLookup(index);

        [MethodImpl(Inline), Op]
        public static string definition(in AsmTokenLookup tokens, AsmTokenKind id)
            => tokens.Definitions[(int)id];

        [MethodImpl(Inline), Op]
        public static string meaning(in AsmTokenLookup tokens, AsmTokenKind id)
            => tokens.Meanings[(int)id];

        [MethodImpl(Inline), Op]
        public static ref readonly TokenRecord token(in AsmTokenLookup tokens, AsmTokenKind id)
            => ref tokens.Models[(int)id];

        [MethodImpl(Inline), Op]
        public static string identifier(in AsmTokenLookup tokens, AsmTokenKind id)
            => tokens.Identity[id];
    }
}