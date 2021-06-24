//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmOperandExpr
    {
        public string Content {get;}

        [MethodImpl(Inline), Op]
        public AsmOperandExpr(string content)
        {
            Content = content;
        }


        public string Format()
            => Content;

        public override string ToString()
            => Format();

        [MethodImpl(Inline), Op]
        public static implicit operator AsmOperandExpr(string src)
            => new AsmOperandExpr(src);
    }
}