//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public class AsmRoutineFormat : ITextual
    {
        public string Content {get;}

        [MethodImpl(Inline)]
        public AsmRoutineFormat(string format)
        {
            Content =  format;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Serialize()
            => text.utf16(Content);

        [MethodImpl(Inline)]
        public string Format()
            => Content;

        public override string ToString()
            => Content;
    }
}