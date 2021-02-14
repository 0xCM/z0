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

    public readonly struct SyntaxToken : ISyntaxToken
    {
        public string Symbol {get;}

        public ulong Kind {get;}

        public string Description {get;}

        [MethodImpl(Inline)]
        public SyntaxToken(string symbol, ulong kind, string description)
        {
            Kind = kind;
            Symbol = symbol;
            Description = description;
        }
    }

    public readonly struct SyntaxToken<K> : ISyntaxToken<K>
        where K : unmanaged
    {
        public string Symbol {get;}

        public K Kind {get;}

        public string Description {get;}

        [MethodImpl(Inline)]
        public SyntaxToken(string symbol, K kind, string description)
        {
            Symbol = symbol;
            Kind = kind;
            Description = description;
        }

        public static implicit operator SyntaxToken(SyntaxToken<K> src)
            => new SyntaxToken(src.Symbol, read64(src.Kind), src.Description);
    }
}