//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct DataGrid<T>
    {
        public readonly string Name;
        
        public readonly TableHeader Header;

        public readonly DataGridRows<T> Rows;

        public DataGrid(string name, TableHeader header, DataGridRow<T>[] data)
        {
            Name = name;
            Header = header;
            Rows = data;
        }
        
        public ref DataGridRow<T> this[int index]
        {
            get => ref Rows[index];
        }
    }
}
