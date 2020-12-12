//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    // public readonly struct MixedPaths
    // {
    //     [MethodImpl(Inline)]
    //     public static MultiArrow<A> connect<A>(MultiArrow<A> head, MultiArrow<A> tail)
    //         where A : IEquatable<A>
    //             => new MultiArrow<A>(head,tail);

    //     [MethodImpl(Inline)]
    //     internal static MultiArrow<A> connect<A>(A[] src, A[] dst)
    //         where A : IEquatable<A>
    //             => new MultiArrow<A>(src,dst);

    //     [MethodImpl(Inline)]
    //     public static MixedPath<S,T> connect<S,T>(S src, T dst)
    //         => new MixedPath<S,T>(src,dst);

    //     internal static string format<S,T>(S src, T dst)
    //         => $"{src}{Connector}{dst}";

    //     [MethodImpl(Inline)]
    //     public static MixedPath<A,B> path<A,B>(A a, B b)
    //         => new MixedPath<A,B>(a,b);

    //     [MethodImpl(Inline)]
    //     public static MixedPath<A,B,C> path<A,B,C>(A a, B b, C c)
    //         => new MixedPath<A,B,C>(a, b, c);

    //     [MethodImpl(Inline)]
    //     public static MixedPath<A,B,C,D> path<A,B,C,D>(A a, B b, C c, D d)
    //         => new MixedPath<A,B,C,D>(a, b, c, d);

    //     [MethodImpl(Inline)]
    //     public static MixedPath<A,B,C,D> join<A,B,C,D>(in MixedPath<A,B> x0, MixedPath<C,D> x1)
    //         => path<A,B,C,D>(x0.Src, x0.Dst, x1.Src, x1.Dst);

    //     [MethodImpl(Inline)]
    //     public static MixedPath<A,C> remove<A,B,C>(in MixedPath<A,B,C> x0, B y)
    //         => path<A,C>(x0.Src, x0.c);
    // }
}