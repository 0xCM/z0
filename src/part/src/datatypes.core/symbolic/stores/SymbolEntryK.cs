//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SymbolEntry<K> : ITextual
        where K : unmanaged
    {
        public uint Index {get;}

        public string Name {get;}

        public K Kind {get;}

        [MethodImpl(Inline)]
        internal SymbolEntry(uint index, SymbolicLiteral<K> value)
        {
            Index = index;
            Kind = value.DirectValue;
            Name = value.Name;
        }

        [MethodImpl(Inline)]
        internal SymbolEntry(uint index, string name, K kind)
        {
            Index = index;
            Name = name;
            Kind = kind;
        }

        public string Format()
            => string.Format("{0}:{1}", Name, Kind);

        public override string ToString()
            => Format();
    }
}