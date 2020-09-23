//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Facet<V>
    {
        public readonly asci32 Name;

        public readonly V Value;

        [MethodImpl(Inline)]
        public static implicit operator Facet<V>((string name, V value) src)
            => new Facet<V>(src.name, src.value);

        [MethodImpl(Inline)]
        public Facet(string name, V value)
        {
            Name = name;
            Value = value;
        }
    }
}