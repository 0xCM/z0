//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    public struct TextRecordFormat
    {
        public Index<TextCellFormat> Cells;
    }

    public struct TextCellFormat
    {
        public ushort Column;

        public ushort LeftPad;

        public ushort RightPad;

        public string Pattern;

        public TextCellFormat(ushort index, ushort lpad, ushort rpad, string pattern)
        {
            Column = index;
            LeftPad = lpad;
            RightPad = rpad;
            Pattern  = pattern;
        }
    }
}