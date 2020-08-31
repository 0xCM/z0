//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    [ApiHost]
    public readonly struct Tx
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Type match<T>(in NumericType10 src)
            where T : unmanaged
                => src.T.match<T>();

        [MethodImpl(Inline), Op]
        public static unsafe ref readonly Type lookup(in NumericType10 src, byte index)
            => ref Unsafe.AsRef<Type>((byte*)pvoid(src) + index);            

        [MethodImpl(Inline)]
        public static unsafe void* pvoid<T>(in T src)
            => Unsafe.AsPointer(ref Unsafe.AsRef(src));    

        [MethodImpl(Inline)]
        public static TxN<T0> T<T0>(T0 t0 = default)
            => default;

        [MethodImpl(Inline)]
        public static TxN<T0,T1> T<T0,T1>(T0 t0 = default, T1 t1 = default)
            => default;

        [MethodImpl(Inline)]
        public static TxN<T0,T1,T2> T<T0,T1,T2>(T0 t0 = default, T1 t1 = default, T2 t2 = default)
            => default;

        [MethodImpl(Inline)]
        public static TxN<T0,T1,T2,T3> T<T0,T1,T2,T3>(T0 t0 = default, T1 t1 = default, T2 t2 = default, 
            T3 t3 = default) => new TxN<T0,T1,T2,T3>(0);

        [MethodImpl(Inline)]
        public static TxN<T0,T1,T2,T3,T4> T<T0,T1,T2,T3,T4>(T0 t0 = default, T1 t1 = default, T2 t2 = default, 
            T3 t3 = default, T4 t4 = default) => new TxN<T0,T1,T2,T3,T4>(0);

        [MethodImpl(Inline)]
        public static TxN<T0,T1,T2,T3,T4,T5> T<T0,T1,T2,T3,T4,T5>(T0 t0 = default, T1 t1 = default, 
            T2 t2 = default, T3 t3 = default, T4 t4 = default, T5 t5 = default) => new TxN<T0,T1,T2,T3,T4,T5>(0);

        [MethodImpl(Inline)]
        public static TxN<T0,T1,T2,T3,T4,T5,T6> T<T0,T1,T2,T3,T4,T5,T6>(T0 t0 = default, T1 t1 = default, 
            T2 t2 = default, T3 t3 = default, T4 t4 = default, T5 t5 = default, T6 t6 = default) 
                => new TxN<T0,T1,T2,T3,T4,T5,T6>(0);

        [MethodImpl(Inline)]
        public static TxN<T0,T1,T2,T3,T4,T5,T6,T7> T<T0,T1,T2,T3,T4,T5,T6,T7>(T0 t0 = default, T1 t1 = default, 
            T2 t2 = default, T3 t3 = default, T4 t4 = default, T5 t5 = default, T6 t6 = default, 
            T7 t7 = default) 
                => new TxN<T0,T1,T2,T3,T4,T5,T6,T7>(0);

        [MethodImpl(Inline)]
        public static TxN<T0,T1,T2,T3,T4,T5,T6,T7,T8> T<T0,T1,T2,T3,T4,T5,T6,T7,T8>(T0 t0 = default, T1 t1 = default, 
            T2 t2 = default, T3 t3 = default, T4 t4 = default, T5 t5 = default, T6 t6 = default, 
            T7 t7 = default, T8 t8 = default) 
                => new TxN<T0,T1,T2,T3,T4,T5,T6,T7,T8>(0);

        [MethodImpl(Inline)]
        public static TxN<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9> T<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(T0 t0 = default, T1 t1 = default, 
            T2 t2 = default, T3 t3 = default, T4 t4 = default, T5 t5 = default, T6 t6 = default, 
            T7 t7 = default, T8 t8 = default, T9 t9 = default) 
                => new TxN<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(0);
    }    
}