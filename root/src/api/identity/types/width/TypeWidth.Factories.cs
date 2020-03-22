//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class TypeWidths
    {        
        public static W1 w1 => default(W1);

        public static W8 w8 => default(W8);

        public static W16 w16 => default(W16);

        public static W32 w32 => default(W32);

        public static W64 w64 => default(W64);

        public static W128 w128 => default(W128);

        public static W256 w256 => default(W256);

        public static W512 w512 => default(W512);

        [MethodImpl(Inline)]
        public static TypeWidth<T> width<T>()        
            where T : unmanaged
                => default(TypeWidth<T>);
    }
}