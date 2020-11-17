//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Facet : IFacet<asci32,variant>
    {
        public asci32 Key {get;}

        public variant Value {get;}

        [MethodImpl(Inline)]
        public Facet(string name, variant value)
        {
            Key = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator Facet((string name, variant value) src)
            => new Facet(src.name, src.value);
    }
}