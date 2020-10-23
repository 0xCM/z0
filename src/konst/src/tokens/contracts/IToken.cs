//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IToken
    {

    }

    public interface IToken<K> : IToken, IIdentified<K>
        where K : unmanaged
    {

    }

    public interface IToken<K,S> : IConstIndex<uint4,K,S>
        where S : unmanaged, ISymbol
        where K : unmanaged
    {
        ReadOnlySpan<S> Symbols {get;}
    }
}