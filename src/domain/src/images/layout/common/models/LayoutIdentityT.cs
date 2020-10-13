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

    public readonly struct LayoutIdentity<T> : ITextual
        where T : unmanaged
    {
        public uint Index {get;}

        public T Kind {get;}

        [MethodImpl(Inline)]
        public LayoutIdentity(uint index, T kind)
        {
            Index = index;
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Index.ToString();

        public override string ToString()
            => Format();
    }
}