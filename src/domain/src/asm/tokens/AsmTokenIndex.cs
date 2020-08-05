//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tokens
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    [ApiHost]
    public readonly partial struct AsmTokenIndex
    {
        const int TokenCount = (int)AsmTokenKind.TokenCount;

        [MethodImpl(Inline), Op]
        public static string identifier(AsmTokenKind kind)
            => AsmTokenIndex.Identity[(int)kind];            

        [MethodImpl(Inline), Op]
        public static string meaning(AsmTokenKind kind)
            => AsmTokenIndex.Meanings[(int)kind];

        [MethodImpl(Inline), Op]
        public static string value(AsmTokenKind kind)
            => AsmTokenIndex.Values[(int)kind];            

        [MethodImpl(Inline), Op]
        public static TokenModel model(AsmTokenKind kind)
            => AsmTokenIndex.Models[(int)kind];
    }        
}