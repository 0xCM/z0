//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct SFx
    {
        [MethodImpl(Inline)]
        public static void map<F,T>(F f, in T src, ref T dst, int count)
            where F : IUnaryOp<T>
        {
            for(var i=0; i<count; i++)
                seek(dst, i) = f.Invoke(skip(src, i));
        }


        [MethodImpl(Inline), Op, Closures(Closure)]
        public ref T map<T>(ValueProjector projector, object x)
            where T : struct
                => ref z.unbox<T>(projector.Delegate((ValueType)x));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T map<T>(ValueProjector<T> f, in T x)
            where T : struct
                => ref z.unbox<T>(f.Delegate(x));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T map<T>(ValueProjector<T,T> f, in T x)
            where T : unmanaged
                => ref f.Delegate(x);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T map<T>(ValueProjector<T,T> f, ValueType x)
            where T : unmanaged
                => ref f.Delegate(z.unbox<T>(x));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T map<T>(ValueProjector<T,T> f, object x)
            where T : unmanaged
                => ref map(f,(ValueType)x);

        [MethodImpl(Inline)]
        public static ref T map<S,T>(ValueProjector<S,T> projector, in S x)
            where S : struct
            where T : struct
                => ref projector.Delegate(x);

        [MethodImpl(Inline)]
        public static ref T map<S,T>(ProjectorProxy<S,T> proxy, object x)
            where S : struct
            where T : struct
                => ref proxy.Project(z.unbox<S>(x));

        [MethodImpl(Inline)]
        public static ref T map<S,T>(ProjectorProxy<S,T> proxy, ValueType x)
            where S : struct
            where T : struct
                => ref proxy.Project(z.unbox<S>(x));
    }
}