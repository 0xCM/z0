//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial struct IntelSdm
    {
        [StructLayout(LayoutKind.Sequential, Pack =1)]
        public struct Volume
        {
            public byte Letter;

            public byte Number;

            [MethodImpl(Inline)]
            public Volume(char letter, byte number)
            {
                Letter = (byte)letter;
                Number = number;
            }
        }
    }
}