//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial class Tuples
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Pairs<T> index<T>(Pair<T>[] src)
            where T : unmanaged
                => src;

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Triples<T> index<T>(Triple<T>[] src)
            where T : unmanaged
                => src;
    }
}