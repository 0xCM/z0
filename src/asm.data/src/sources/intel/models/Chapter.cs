//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct IntelSdm
    {
        public struct Chapter
        {
            public byte Number;

            [MethodImpl(Inline)]
            public Chapter(byte number)
            {
                Number = number;
            }

            public string Format()
                => Number.ToString();

            public override string ToString()
                => Format();

            public static implicit operator Chapter(byte src)
                => new Chapter(src);

            public static implicit operator Chapter(int src)
                => new Chapter((byte)src);
        }
    }
}