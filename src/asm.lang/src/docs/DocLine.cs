//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmDocParts
    {
        public readonly struct DocLine
        {
            /// <summary>
            /// The content line number
            /// </summary>
            public uint Number {get;}

            /// <summary>
            /// The line content
            /// </summary>
            public TextBlock Content {get;}

            [MethodImpl(Inline)]
            public DocLine(uint number, TextBlock content)
            {
                Number = number;
                Content = content;
            }

            [MethodImpl(Inline)]
            public string Format()
                => Content.Format();

            public override string ToString()
                => Format();
        }
    }
}