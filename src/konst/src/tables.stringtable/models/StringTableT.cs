//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct StringTable<T>
    {
        readonly string Name;

        readonly TableHeader Header;

        StringTableRows<T> Data;


        [MethodImpl(Inline)]
        public StringTable(string name, TableHeader header, StringTableRow<T>[] rows)
        {
            Name = name;
            Header = header;
            Data = rows;
        }

        public ref StringTableRow<T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref StringTableRow<T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        [MethodImpl(Inline)]
        public StringTable<T> Fill(StringTableRow<T>[] src)
        {
            Data = src;
            return this;
        }
    }
}