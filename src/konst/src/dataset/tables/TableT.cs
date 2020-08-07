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
        where T : ITable
    {
        public readonly string Name;
        
        public readonly TableHeader Header;

        public readonly TableRows<T> Rows;

        public Table(string name, TableHeader header, TableRow<T>[] data)
        {
            Name = name;
            Header = header;
            Rows = data;
        }
        
        public ref TableRow<T> this[int index]
        {
            get => ref Rows[index];
        }
    }
}
