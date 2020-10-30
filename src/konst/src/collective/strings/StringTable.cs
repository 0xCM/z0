//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct StringTable
    {
        readonly string _Name;

        readonly TableHeader _Header;

        StringTableRows _Rows;

        [MethodImpl(Inline)]
        public StringTable(string name, TableHeader header, StringTableRow[] rows)
        {
            _Name = name;
            _Header = header;
            _Rows = rows;
        }

        public ref StringTableRow this[int index]
        {
            [MethodImpl(Inline)]
            get => ref _Rows[index];
        }

        public ref StringTableRow this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref _Rows[index];
        }

        public readonly string Name
        {
            [MethodImpl(Inline)]
            get => _Name;
        }

        public readonly TableHeader Header
        {
            [MethodImpl(Inline)]
            get => _Header;
        }

        [MethodImpl(Inline)]
        public StringTable Fill(StringTableRow[] src)
        {
            _Rows = src;
            return this;
        }
    }
}