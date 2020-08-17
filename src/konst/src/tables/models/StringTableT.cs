//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct StringTable<T>
        where T : ITextual
    {
        public readonly string Name;
        
        public readonly TableHeader Header;

        public readonly StringTableRows<T> Rows;                
        
        [MethodImpl(Inline)]
        public StringTable(string name, TableHeader header, StringTableRow<T>[] rows)
        {
            Name = name;
            Header = header;
            Rows = rows;
        }        

        public ref StringTableRow<T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Rows[index];
        }

        public ref StringTableRow<T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Rows[index];
        }
    }
}