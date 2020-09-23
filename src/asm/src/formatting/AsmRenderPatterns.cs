//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static RP;

    public readonly struct AsmRenderPatterns
    {
        public const byte OpKindPad  = 20;

        public const byte SeqDigitPad = 2;

        public const byte InstructionCountPad = 3;

        public const byte OffsetAddrPad = 12;

        public const byte AddressPad = 16;

        public const byte SizePad = 5;

        public const byte FxWidth = 80;

        public const string FxDelimiter = Dash80;

        public const byte Col0Pad = 10;

        public const byte ColSepWidth = 3;

        public const byte Counter = 4;

        public const byte CounterPad = 1;

        public const byte LocSepWidth = ColSepWidth;

        public const byte SectionWidth = AddressPad + OffsetAddrPad + FxWidth + Counter + SizePad + CounterPad + ColSepWidth;

        public const string LeftImply = " <== ";

        public const string ColSep = " | ";

        public const string HeaderSep = " || ";

        public const string Assign = " = ";

        public static string SectionSep
            => new string(Chars.Dash, SectionWidth);
    }
}