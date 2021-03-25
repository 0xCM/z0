//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmLine
    {
        public uint LineNumber {get;}

        public TextBlock Content {get;}

        [MethodImpl(Inline)]
        public AsmLine(uint number, TextBlock content)
        {
            LineNumber = number;
            Content = content;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();

        public static AsmLine Empty
        {
            [MethodImpl(Inline)]
            get => new AsmLine(0, EmptyString);
        }
    }
}