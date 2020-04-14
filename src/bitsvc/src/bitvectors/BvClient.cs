//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    [ApiHost]
    class BvClient : IApiHost<BvClient>
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitVector<T> add<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BV.add<T>().Invoke(x,y);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitVector<T> sub<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BV.sub<T>().Invoke(x,y);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitVector<T> and<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BV.and<T>().Invoke(x,y);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bit dot<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BV.dot<T>().Invoke(x,y);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitVector<T> gather<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BV.gather<T>().Invoke(x,y);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitVector<T> nand<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BV.nand<T>().Invoke(x,y);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitVector<T> nor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BV.nor<T>().Invoke(x,y);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitVector<T> not<T>(BitVector<T> x)
            where T : unmanaged
                => BV.not<T>().Invoke(x);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitVector<T> or<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BV.or<T>().Invoke(x,y);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitVector<T> xnor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BV.xnor<T>().Invoke(x,y);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitVector<T> xor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BV.xor<T>().Invoke(x,y);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static int width<T>(BitVector<T> x)
            where T : unmanaged
                => BV.width<T>().Invoke(x);
    }
}