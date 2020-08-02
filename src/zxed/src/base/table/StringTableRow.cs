//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct StringTableRow
    {    
        public readonly string[] Cells;
        
        [MethodImpl(Inline)]
        public StringTableRow(string[] cells)
        {
            Cells = cells;            
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Cells.Length;
        }

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => (uint)Cells.Length;
        }

        public ref string this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Cells[index];
        }
    }
}