//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public readonly partial struct IntelSdm
    {
        public readonly struct InstructionTable
        {
            const string NL = "\r\n";

            const string Line0 = "Opcode";

            const string Line1 = "Instruction";

            const string Line2 = "Op/";

            const string Line3 = "En";

            const string Line4 = "64-bit";

            const string Line5 = "Mode";

            const string Line6 = "Compat/";

            const string Line7 = "Leg Mode";

            const string Line8 = "Description";

            public const string Lines = Line0 + NL + Line1 + NL + Line2 + NL + Line3 + NL + Line4 + NL + Line5 + NL + Line6 + NL + Line7 + NL + Line8;

            public static ReadOnlySpan<byte> HeaderMatch
                => new byte[74]{79, 112, 99, 111, 100, 101, 13, 10, 73, 110, 115, 116, 114, 117, 99, 116, 105, 111, 110, 13, 10, 79, 112, 47, 13, 10, 69, 110, 13, 10, 54, 52, 45, 98, 105, 116, 13, 10, 77, 111, 100, 101, 13, 10, 67, 111, 109, 112, 97, 116, 47, 13, 10, 76, 101, 103, 32, 77, 111, 100, 101, 13, 10, 68, 101, 115, 99, 114, 105, 112, 116, 105, 111, 110};
        }
    }
}