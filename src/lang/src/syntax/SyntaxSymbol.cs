//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct SyntaxSymbol
    {
        public uint Order {get;}

        public ulong Kind {get;}

        public Name Name {get;}

        public TextBlock Description {get;}

        [MethodImpl(Inline)]
        public SyntaxSymbol(uint order, ulong kind, Name name, TextBlock description)
        {
            Kind = kind;
            Order = order;
            Name = name;
            Description = description;
        }
    }

    public readonly struct SyntaxSymbol<K>
        where K : unmanaged
    {
        public uint Order {get;}

        public K Kind {get;}

        public Name Name {get;}

        public TextBlock Description {get;}

        [MethodImpl(Inline)]
        public SyntaxSymbol(uint key, K kind, Name name, TextBlock description)
        {
            Kind = kind;
            Order = key;
            Name = name;
            Description = description;
        }

        public static implicit operator SyntaxSymbol(SyntaxSymbol<K> src)
            => new SyntaxSymbol(src.Order, read64(src.Kind), src.Name, src.Description);
    }
}