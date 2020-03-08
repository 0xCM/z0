//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    public static class Arrows
    {
        public static Arrow<S,T> connect<S,T>(S src, T dst)
            where S : IIdentity<S>, new()
            where T : IIdentity<T>, new()
                => new Arrow<S,T>(src,dst);

        public static Arrow<V> connect<V>(V src, V dst)
            where V : IIdentity<V>, new()
                => new Arrow<V>(src,dst);

        internal static string format<S,T>(S src, T dst)            
            => $"{src} -> {dst}";
    }
}