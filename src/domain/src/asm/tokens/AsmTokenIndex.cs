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
    public partial class AsmTokenIndex
    {
        const int TokenCount = (int)AsmTokenKind.TokenCount;

        [MethodImpl(Inline), Op]
        public static AsmTokenIndex create()
            => new AsmTokenIndex();

        [MethodImpl(Inline), Op]
        public string identifier(AsmTokenKind kind)
            => Identity[(int)kind];            

        [MethodImpl(Inline), Op]
        public string meaning(AsmTokenKind kind)
            => Meanings[(int)kind];

        [MethodImpl(Inline), Op]
        public string value(AsmTokenKind kind)
            => Values[(int)kind];            

        [MethodImpl(Inline), Op]
        public TokenModel model(AsmTokenKind kind)
            => Models[(int)kind];
    }        
}