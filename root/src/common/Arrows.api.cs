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
        public const string Connector = " -> ";

        [MethodImpl(Inline)]
        public static Arrow<S,T> connect<S,T>(S src, T dst)
            where S : IIdentity<S>, new()
            where T : IIdentity<T>, new()
                => new Arrow<S,T>(src,dst);

        [MethodImpl(Inline)]
        public static Arrow<V> connect<V>(V src, V dst)
            where V : IIdentity<V>, new()
                => new Arrow<V>(src,dst);

        internal static string format<S,T>(S src, T dst)            
            => $"{src}{Connector}{dst}";

        [MethodImpl(Inline)]
        public static Path<A,B> path<A,B>(A a, B b)
            => new Path<A,B>(a,b);

        [MethodImpl(Inline)]
        public static Path<A,B,C> path<A,B,C>(A a, B b, C c)
            => new Path<A,B,C>(a, b, c);

        [MethodImpl(Inline)]
        public static Path<A,B,C,D> path<A,B,C,D>(A a, B b, C c, D d)
            => new Path<A,B,C,D>(a, b, c, d);
        
        [MethodImpl(Inline)]
        public static Path<A,B,C> join<A,B,C>(in Path<A,B> x0, Path<C> x1)
            => path<A,B,C>(x0.a, x0.b, x1.a);

        [MethodImpl(Inline)]
        public static Path<A,B,C,D> join<A,B,C,D>(in Path<A,B,C> x0, Path<D> x1)
            => path<A,B,C,D>(x0.a, x0.b, x0.c, x1.a);

        [MethodImpl(Inline)]
        public static Path<A,B,C,D> join<A,B,C,D>(in Path<A,B> x0, Path<C,D> x1)
            => path<A,B,C,D>(x0.a, x0.b, x1.a, x1.b);

        [MethodImpl(Inline)]
        public static Path<A,C> remove<A,B,C>(in Path<A,B,C> x0, B y)
            => path<A,C>(x0.a, x0.c);

    }
}