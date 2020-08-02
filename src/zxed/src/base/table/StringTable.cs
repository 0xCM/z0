//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct StringTable
    {
        public readonly string Name;
        
        public readonly TableHeader Header;

        public readonly StringTableRows Rows;                
        
        [MethodImpl(Inline)]
        public StringTable(string name, TableHeader header, StringTableRow[] rows)
        {
            Name = name;
            Header = header;
            Rows = rows;
        }        

        public ref StringTableRow this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Rows[index];
        }

        public ref StringTableRow this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Rows[index];
        }
    }
}