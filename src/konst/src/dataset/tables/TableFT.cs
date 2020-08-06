//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Table<F,T>
        where F : unmanaged, Enum
        where T : ITable<F>
    {
        public readonly string Name;
        
        public readonly TableHeader<F> Header;

        public readonly TableRows<T> Rows;

        [MethodImpl(Inline)]
        public Table(string name, TableHeader<F> header, TableRow<T>[] data)
        {
            Name = name;
            Header = header;
            Rows = data;
        }
        
        public ref TableRow<T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Rows[index];
        }
    }    
}