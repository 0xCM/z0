//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    class FormatConstants
    {
        public const string LeftImply = "<==";

        public const string RightImply = "==>";

        public const string ColSep = " | ";

        public const char LineSepSymbol = Chars.Dash;

        public const byte ColSepWidth = 3;

        public const byte Counter = 4;

        public const byte CounterPad = 1;

        public const byte SizePad = 5;   

        public const byte AddressPad = 16;     
    
        public const byte InstructionCountPad = 3;

        public const byte SubGridWidth = 80;

        public const byte InstructionKindPad  = 20;

        public const byte OperandIndexDigits = 2;

        public const byte OperandIndexPad = 6;

        public const byte SectionWidth = AddressPad + SubGridWidth + Counter + SizePad + CounterPad + ColSepWidth;

        public static string SubGridSep 
            = new string(LineSepSymbol, SubGridWidth);
        
        public static string SectionSep 
            = new string(LineSepSymbol, SectionWidth);   
    }
}