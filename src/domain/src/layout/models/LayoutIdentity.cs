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

    public readonly struct LayoutIdentity : ITextual
    {
        public uint Index {get;}

        public ulong Kind {get;}

        [MethodImpl(Inline)]
        public LayoutIdentity(uint index, ulong src)
        {
            Index = index;
            Kind = src;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Index.ToString();

        public override string ToString()
            => Format();
    }
}