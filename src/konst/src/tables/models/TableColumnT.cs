//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct TableColumn<F> : ITextual
        where F : unmanaged
    {
        /// <summary>
        /// The field specifier
        /// </summary>
        public F Id {get;}

        /// <summary>
        /// The field name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The 0-based field index
        /// </summary>
        public ushort Index {get;}

        /// <summary>
        /// The field width
        /// </summary>
        public ushort Width {get;}

        [MethodImpl(Inline)]
        public TableColumn(F id, string name, ushort index, ushort width)
        {
            Id = id;
            Name = name;
            Index = index;
            Width = width;
        }

        public string Format()
            => String.Concat($"{Index}".PadLeft(2,'0'), Space, $"{Width}".PadLeft(2,'0'), Space, Name);

        public override string ToString()
            => Format();
    }
}