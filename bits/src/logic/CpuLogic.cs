//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static As;

    public static class CpuLogic
    {

        [MethodImpl(Inline)]
        public static Vec128<T> identity<T>(in Vec128<T> a)
            where T : unmanaged
                => a;

        [MethodImpl(Inline)]
        public static Vec128<T> zero<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Vec128<T> one<T>()
            where T : unmanaged
                => ginx.loadu128(in Ones.As<T>()[0]);

        [MethodImpl(Inline)]
        public static Vec128<T> not<T>(in Vec128<T> a)
            where T : unmanaged
                => ginx.vnot(a);

        [MethodImpl(Inline)]
        public static Vec128<T> negate<T>(in Vec128<T> a)
            where T : unmanaged
                => ginx.vnegate(a);

        [MethodImpl(Inline)]
        public static Vec128<T> and<T>(in Vec128<T> a, in Vec128<T> b)
            where T : unmanaged
                => ginx.vand(a,b);

        [MethodImpl(Inline)]
        public static Vec128<T> nand<T>(in Vec128<T> a, in Vec128<T> b)
            where T : unmanaged
                => not(and(a,b));

        [MethodImpl(Inline)]
        public static Vec128<T> or<T>(in Vec128<T> a, in Vec128<T> b)
            where T : unmanaged
                => ginx.vor(a,b);

        [MethodImpl(Inline)]
        public static Vec128<T> nor<T>(in Vec128<T> a, in Vec128<T> b)
            where T : unmanaged
                => not(or(a,b));

        [MethodImpl(Inline)]
        public static Vec128<T> xor<T>(in Vec128<T> a, in Vec128<T> b)
            where T : unmanaged
                => ginx.vxor(a,b);

        [MethodImpl(Inline)]
        public static Vec128<T> xnor<T>(in Vec128<T> a, in Vec128<T> b)
            where T : unmanaged
                => not(xor(a,b));

        [MethodImpl(Inline)]
        public static Vec128<T> xor1<T>(in Vec128<T> a)
            where T : unmanaged
                => xor(a, one<T>());

        [MethodImpl(Inline)]
        public static Vec128<T> select<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => or(and(a, b), and(not(a), c));            


        // a nor (b or c)
        [MethodImpl(Inline)]
        public static Vec128<T> f01<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
            => nor(a, or(b,c));

        // c and (b nor a)
        [MethodImpl(Inline)]
        public static Vec128<T> f02<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => and(c, nor(b,a));
 
         // b nor a
        [MethodImpl(Inline)]
        public static Vec128<T> f03<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => nor(b,a);

        static ReadOnlySpan<byte> Ones => new byte[16]
        {
            0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
            0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
        };
        
    }

}

