//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static Memories;
    
    /// <summary>
    /// Defines a text segment in the context of a line in a file
    /// </summary>
    public readonly struct TextCell
    {        
        public uint LineNumber {get;}

        public uint ColumnIndex {get;}

        public string CellValue {get;}

        public TextCell(uint LineNumber, uint ColumnIndex, string CellValue)
        {
            this.LineNumber = LineNumber;
            this.ColumnIndex = ColumnIndex;
            this.CellValue = insist(CellValue);
        }        
    }
}