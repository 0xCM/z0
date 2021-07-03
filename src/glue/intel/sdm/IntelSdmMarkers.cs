//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static IntelSdm;

    using Markers = IntelSdmMarkers;

    public readonly struct IntelSdmMarkers
    {
        public const string ChapterNumber = "CHAPTER ";

        public const string TableNumber = "Table ";

        public const string Intrinsics = "Intel C/C++ Compiler Intrinsic Equivalent";

        public const string TocTitle = " . . . . . . . . . .";

        public static int index(ReadOnlySpan<char> src, string marker)
        {
            var index = src.IndexOf(marker);
            if(index > Markers.TableNumber.Length)
                return NotFound;
            else
                return index;
        }

        public const string InstructionPageFooter_A_Left = "{Mnemonic} — {FullName}";

        public const string InstructionPageFooter_A_Right_A = VolNumber.Descriptor;

        public const string InstructionPageFooter_A_Right_B = ChapterPage.Descriptor;

        public readonly struct InstructionTable
        {
            const string NL = "\r\n";

            public const string Line0 = "Opcode";

            public const string Line1 = "Instruction";

            public const string Line2 = "Op/";

            public const string Line3 = "En";

            public const string Line4 = "64-bit";

            public const string Line5 = "Mode";

            public const string Line6 = "Compat/";

            public const string Line7 = "Leg Mode";

            public const string Line8 = "Description";

            public const string Lines = Line0 + NL + Line1 + NL + Line2 + NL + Line3 + NL + Line4 + NL + Line5 + NL + Line6 + NL + Line7 + NL + Line8;

            public static ReadOnlySpan<byte> HeaderMatch
                => new byte[74]{79, 112, 99, 111, 100, 101, 13, 10, 73, 110, 115, 116, 114, 117, 99, 116, 105, 111, 110, 13, 10, 79, 112, 47, 13, 10, 69, 110, 13, 10, 54, 52, 45, 98, 105, 116, 13, 10, 77, 111, 100, 101, 13, 10, 67, 111, 109, 112, 97, 116, 47, 13, 10, 76, 101, 103, 32, 77, 111, 100, 101, 13, 10, 68, 101, 115, 99, 114, 105, 112, 116, 105, 111, 110};
        }
    }
}