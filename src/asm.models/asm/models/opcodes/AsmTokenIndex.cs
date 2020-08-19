//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
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
        {
            var index = new AsmTokenIndex();


            return index;    
        }

        [MethodImpl(Inline), Op]
        public ref readonly string identifier(AsmTokenKind kind)
            => ref Identifier[kind];            

        [MethodImpl(Inline), Op]
        public string meaning(AsmTokenKind kind)
            => Meaning[(int)kind];

        [MethodImpl(Inline), Op]
        public string value(AsmTokenKind kind)
            => Value[(int)kind];            

        [MethodImpl(Inline), Op]
        public TokenModel model(AsmTokenKind kind)
            => Model[(int)kind];
    }        
}