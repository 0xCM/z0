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
        public static AsmFxTokens tokens(in AsmTokenIndex index)
            => new AsmFxTokens(index);

        [MethodImpl(Inline), Op]
        public static string definition(in AsmFxTokens tokens, AsmTokenKind id)
            => tokens.Definitions[(int)id];

        [MethodImpl(Inline), Op]
        public static string meaning(in AsmFxTokens tokens, AsmTokenKind id)
            => tokens.Meanings[(int)id];

        [MethodImpl(Inline), Op]
        public static ref readonly TokenModel token(in AsmFxTokens tokens, AsmTokenKind id)
            => ref tokens.Models[(int)id];

        [MethodImpl(Inline), Op]
        public static string identifier(in AsmFxTokens tokens, AsmTokenKind id)
            => tokens.Identity[(int)id];
    }
}