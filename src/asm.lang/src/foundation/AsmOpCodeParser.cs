//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;


    using static Part;
    using static memory;
    using static Chars;

    [ApiHost]
    public ref struct AsmOpCodeParser
    {
        ReadOnlySpan<char> Data;

        readonly string Content;


        [MethodImpl(Inline)]
        public AsmOpCodeParser(AsmOpCodeExpr src)
        {
            Data = src.Data;
            Content = src.Content;
        }

        [Op]
        public bool HasRex()
            => Content.StartsWith("REX");

        [Op]
        public bool HasVex()
            => Content.StartsWith("VEX");
    }
}