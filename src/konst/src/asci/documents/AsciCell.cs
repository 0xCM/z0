//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
        
    /// <summary>
    /// Defines a text segment in the context of a line in a file
    /// </summary>
    public readonly struct AsciCell
    {        
        public readonly uint Row;

        public readonly uint Col;

        public readonly AsciSymbols Data;
                
        [MethodImpl(Inline)]
        internal AsciCell(uint row, uint col, AsciSymbols data)
        {
            Row = row;
            Col = col;
            Data = data;
        }    

        public char this[uint index]    
        {
            [MethodImpl(Inline)]
            get => Data[index];
        }

        /// <summary>
        /// Specifies the number of symbols covered by the cell
        /// </summary>
        public uint Width
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ReadOnlySpan<AsciSymbol> View
        {
            [MethodImpl(Inline)]
            get => Data.Data;
        }
    }
}