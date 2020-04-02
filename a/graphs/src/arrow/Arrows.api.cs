//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Graphs;

    public static class Arrows
    {        
        [MethodImpl(Inline)]
        public static ArrowPath<S,T> connect<S,T>(S src, T dst)
            where S : IIdentifiedTarget<S>, new()
            where T : IIdentifiedTarget<T>, new()
                => new ArrowPath<S,T>(src,dst);

        internal static string format<S,T>(S src, T dst)            
            => $"{src}{Connector}{dst}";

        [MethodImpl(Inline)]
        public static ArrowPath<A,B> path<A,B>(A a, B b)
            => new ArrowPath<A,B>(a,b);

        [MethodImpl(Inline)]
        public static MixedPath<A,B,C> path<A,B,C>(A a, B b, C c)
            => new MixedPath<A,B,C>(a, b, c);

        [MethodImpl(Inline)]
        public static MixedPath<A,B,C,D> path<A,B,C,D>(A a, B b, C c, D d)
            => new MixedPath<A,B,C,D>(a, b, c, d);
        

        [MethodImpl(Inline)]
        public static MixedPath<A,B,C,D> join<A,B,C,D>(in ArrowPath<A,B> x0, ArrowPath<C,D> x1)
            => path<A,B,C,D>(x0.Src, x0.Dst, x1.Src, x1.Dst);

        [MethodImpl(Inline)]
        public static ArrowPath<A,C> remove<A,B,C>(in MixedPath<A,B,C> x0, B y)
            => path<A,C>(x0.Src, x0.c);

        const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }
}