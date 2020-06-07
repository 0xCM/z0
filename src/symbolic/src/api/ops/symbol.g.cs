//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class Symbolic
    {
        [MethodImpl(Inline), Op]   
        public static Symbol<S> symbol<S>(S value)
            where S : unmanaged
                => new Symbol<S>(value);

        [MethodImpl(Inline), Op]   
        public static Symbol<S,T> symbol<S,T>(S value, T t = default)
            where S : unmanaged
            where T : unmanaged
                => new Symbol<S,T>(value);

        [MethodImpl(Inline), Op]   
        public static Symbol<S,T,N> symbol<S,T,N>(S value, T t = default, N n = default)
            where S : unmanaged
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => new Symbol<S,T,N>(value);
    }
}