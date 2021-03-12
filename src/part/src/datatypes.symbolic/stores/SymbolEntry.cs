//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SymbolEntry<E>
    {
        public uint Index {get;}

        public Name Name {get;}

        public E Kind {get;}

        [MethodImpl(Inline)]
        internal SymbolEntry(uint index, SymbolicLiteral<E> value)
        {
            Index = index;
            Kind = value.DirectValue;
            Name = value.Name;
        }
    }
}