//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    class FormatConstants
    {
        public const int Counter = 4;

        public const int CounterPad = 1;

        public const int SizePad = 5;   

        public const int IdPad = 30;     
    
        public const int InstructionCountPad = 3;

        public const int InstructionHeaderLength = 80;

        public const int SubTitlePad = 4;     

        public const string OpCodeDelimiter = "<==";

        public const string HorizontalSep = " | ";

        public const int InstructionKindPad  = 16;

        public const int OperandIndexPad = 2;

        // 80 chars
        public static string SectionSep = new string(Chars.Dash, InstructionHeaderLength);

        public static string FunctionSep 
            = new string(Chars.Dash, IdPad + InstructionHeaderLength + Counter + SizePad + CounterPad + HorizontalSep.Length);   
    }
}