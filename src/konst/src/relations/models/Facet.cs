//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Facet
    {
        public readonly asci32 Name;

        public readonly variant Value;

        [MethodImpl(Inline)]
        public Facet(string name, variant value)
        {
            Name = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator Facet((string name, variant value) src)
            => new Facet(src.name, src.value);
    }
}