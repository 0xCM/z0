//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Table<T>
    {
        public readonly string Name;
        
        public readonly TableHeader Header;

        public readonly Rows<T> Rows;

        public Table(string name, TableHeader header, Row<T>[] data)
        {
            Name = name;
            Header = header;
            Rows = data;
        }
        
        public ref Row<T> this[int index]
        {
            get => ref Rows[index];
        }
    }
}
