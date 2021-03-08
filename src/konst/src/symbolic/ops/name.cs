//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Symbolic
    {
        public static Identifier name<S>(ISymbol<S> src)
            where S : unmanaged
                => src.Value is Enum e ? e.ToString("g") : src.Value.ToString();

        public static Identifier name<K,S>(IKindedSymbol<K,S> src)
            where K : unmanaged
            where S : unmanaged
                => src.Kind is Enum e ? e.ToString("g") : src.Kind.ToString();
    }
}