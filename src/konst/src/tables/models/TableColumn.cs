//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct TableColumn
    {
        public ushort Index {get;}

        public StringRef Name {get;}

        public ushort Width {get;}

        [MethodImpl(Inline)]
        public TableColumn(ushort index, string name, ushort width)
        {
            Index = index;
            Name = name;
            Width = (byte)width;
        }

        public string Format()
            => String.Concat($"{Index}".PadLeft(2,'0'), Space, $"{Width}".PadLeft(2,'0'), Space, Name);
    }
}