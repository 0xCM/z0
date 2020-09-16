//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static Asm.AsmTokens tokens(in AsmTokenIndex index)
            => new Asm.AsmTokens(index);

        [MethodImpl(Inline), Op]
        public static string definition(in Asm.AsmTokens tokens, AsmTokenKind id)
            => tokens.Definitions[(int)id];

        [MethodImpl(Inline), Op]
        public static string meaning(in Asm.AsmTokens tokens, AsmTokenKind id)
            => tokens.Meanings[(int)id];

        [MethodImpl(Inline), Op]
        public static ref readonly TokenInfo token(in Asm.AsmTokens tokens, AsmTokenKind id)
            => ref tokens.Models[(int)id];

        [MethodImpl(Inline), Op]
        public static string identifier(in Asm.AsmTokens tokens, AsmTokenKind id)
            => tokens.Identity[id];
    }
}