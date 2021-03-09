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

    partial struct SymbolStores
    {
        [MethodImpl(Inline), Closures(Closure)]
        public static char @char<S>(Symbol<S> src)
            where S : unmanaged, IEquatable<S>
                => @as<S,char>(src.Value);

        [MethodImpl(Inline)]
        public static char @char<S,T>(Symbol<S,T> src)
            where S : unmanaged, IEquatable<S>
            where T : unmanaged
                => @as<S,char>(src.Value);

        [MethodImpl(Inline)]
        public static char @char<S,T,N>(Symbol<S,T,N> src)
            where S : unmanaged, IEquatable<S>
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => @as<S,char>(src.Value);
    }
}