//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
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
                => ref memory.unbox<T>(projector.Delegate((ValueType)x));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T map<T>(ValueProjector<T> f, in T x)
            where T : struct
                => ref memory.unbox<T>(f.Actor(x));

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


        [MethodImpl(Inline)]
        public static ref readonly SpanBlock128<T> map<F,T>(in SpanBlock128<T> src, in SpanBlock128<T> dst, F f)
            where T : unmanaged
            where F : IUnaryOp128<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(src.LoadVector(block)).StoreTo(dst, block);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly SpanBlock256<T> map<F,T>(in SpanBlock256<T> src, in SpanBlock256<T> dst, F f)
            where T : unmanaged
            where F : IUnaryOp256<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(src.LoadVector(block)).StoreTo(dst, block);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static Span<Bit32> map<F,T>(in SpanBlock128<T> src, in Span<Bit32> dst, F f)
            where T : unmanaged
            where F : IUnaryPred128<T>
        {
            var blocks = src.BlockCount;
            ref var result = ref z.first(dst);
            for(var block = 0; block < blocks; block++)
                z.seek(result, block) = f.Invoke(src.LoadVector(block));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<Bit32> map<F,T>(in SpanBlock256<T> src, Span<Bit32> dst, F f)
            where T : unmanaged
            where F : IUnaryPred256<T>
        {
            var blocks = src.BlockCount;
            ref var result = ref z.first(dst);
            for(var block = 0; block < blocks; block++)
                z.seek(result, block) = f.Invoke(src.LoadVector(block));
            return dst;
        }
    }
}