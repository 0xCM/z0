//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct BvSvcClient
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public BitVector<T> add<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BvSvc.add<T>().Invoke(x,y);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public BitVector<T> sub<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BvSvc.sub<T>().Invoke(x,y);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public BitVector<T> and<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BvSvc.and<T>().Invoke(x,y);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public Bit32 dot<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BvSvc.dot<T>().Invoke(x,y);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public BitVector<T> gather<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BvSvc.gather<T>().Invoke(x,y);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public BitVector<T> nand<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BvSvc.nand<T>().Invoke(x,y);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public BitVector<T> nor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BvSvc.nor<T>().Invoke(x,y);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public BitVector<T> not<T>(BitVector<T> x)
            where T : unmanaged
                => BvSvc.not<T>().Invoke(x);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public BitVector<T> or<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BvSvc.or<T>().Invoke(x,y);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public BitVector<T> xnor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BvSvc.xnor<T>().Invoke(x,y);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public BitVector<T> xor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BvSvc.xor<T>().Invoke(x,y);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public int width<T>(BitVector<T> x)
            where T : unmanaged
                => BvSvc.effwidth<T>().Invoke(x);
    }
}