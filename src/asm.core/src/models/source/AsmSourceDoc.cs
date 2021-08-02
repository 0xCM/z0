//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmSourceDoc
    {
        public TextBlock Content {get;}

        [MethodImpl(Inline)]
        public AsmSourceDoc(string content)
        {
            Content = content;
        }

        public static AsmSourceDoc Empty
        {
            [MethodImpl(Inline)]
            get => new AsmSourceDoc(EmptyString);
        }
    }
}