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

    public readonly struct Facet<S,T>
    {
        public readonly asci32 Name;

        public readonly variant Value;

        public static implicit operator Facet<S,T>(Paired<asci32,variant> src)
            => new Facet<S,T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public Facet(asci32 name, variant value)
        {
            Name = name;
            Value = value;
        }
    }
}