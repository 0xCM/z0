//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;

    using static zfunc;

    using static BitMasks;

    partial class BitMask
    {                
        [MethodImpl(Inline)]
        public static MsbMask<F,D,T> msbspec<F,D,T>(F f = default, D d = default, T t = default) 
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
                => default;


        [MethodImpl(Inline)]
        public static LsbMask<F,D,T> lsbspec<F,D,T>(F f = default, D d = default, T t = default) 
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static CentralMask<F,D,T> centralspec<F,D,T>(F f = default, D d = default, T t = default) 
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static JsbMask<F,D,T> jsbspec<F,D,T>(F f = default, D d = default, T t = default) 
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
                => default;

        /// <summary>
        /// [00000001]    
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(LsbMask<N1,N1,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [01]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(LsbMask<N2,N1,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [0001]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(LsbMask<N4,N1,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [00000001]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(LsbMask<N8,N1,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [00000000 00000001]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(LsbMask<N16,N1,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [00000011]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(LsbMask<N8,N2,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);
 
         /// <summary>
        /// [000000111]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(LsbMask<N8,N3,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [00000111]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(LsbMask<N8,N4,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [00011111]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(LsbMask<N8,N5,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [00111111]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(LsbMask<N8,N6,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [01111111]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(LsbMask<N8,N7,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [1000...0000]    
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(MsbMask<N1,N1,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [10]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(MsbMask<N2,N1,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [10001000]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(MsbMask<N4,N1,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [10000000]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(MsbMask<N8,N1,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [10000000 00000000]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(MsbMask<N16,N1,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

         /// <summary>
        /// [11000000]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(MsbMask<N8,N2,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [11100000]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(MsbMask<N8,N3,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [11110000]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(MsbMask<N8,N4,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [11111000]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(MsbMask<N8,N5,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [11111100]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(MsbMask<N8,N6,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [11111110]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(MsbMask<N8,N7,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [10000001]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T jsb<T>(JsbMask<N8,N1,T> spec)
            where T : unmanaged
                => jsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [11000011]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T jsb<T>(JsbMask<N8,N2,T> spec)
            where T : unmanaged
                => jsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [00011000]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T central<T>(CentralMask<N8,N2,T> spec)
            where T : unmanaged
                => central(spec.f,spec.d, spec.t);

        /// <summary>
        /// [00111100]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T central<T>(CentralMask<N8,N4,T> spec)
            where T : unmanaged
                => central(spec.f,spec.d, spec.t);

        /// <summary>
        /// [01111110]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T central<T>(CentralMask<N8,N6,T> spec)
            where T : unmanaged
                => central(spec.f,spec.d, spec.t);

        /// <summary>
        /// [11100111]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T jsb<T>(JsbMask<N8,N3,T> spec)
            where T : unmanaged
                => jsb(spec.f,spec.d,spec.t);

        public interface IMaskSpec<F,D,T>
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
        {
            public F f => default;

            public D d => default;

            public T t => default;

        }

        public readonly struct MsbMask<F,D,T> : IMaskSpec<F,D,T>
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
        {
            public F f => default;

            public D d => default;

            public T t => default;

            public MsbMask<F,D,S> As<S>(S s = default)
                where S : unmanaged
                    => default;

            public override string ToString()
                => $"msb, f:{natval<F>()}, d:{natval<D>()}, t:{moniker<T>()}";
        }

        public readonly struct LsbMask<F,D,T> : IMaskSpec<F,D,T>
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
        {
            public F f => default;

            public D d => default;

            public T t => default;

            public LsbMask<F,D,S> As<S>(S s = default)
                where S : unmanaged
                    => default;

            public override string ToString()
                => $"lsb, f:{natval<F>()}, d:{natval<D>()}, t:{moniker<T>()}";
        }

        public readonly struct JsbMask<F,D,T> : IMaskSpec<F,D,T>
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
        {
            public F f => default;

            public D d => default;

            public T t => default;

            public JsbMask<F,D,S> As<S>(S s = default)
                where S : unmanaged
                    => default;

            public override string ToString()
                => $"jsb, f:{natval<F>()}, d:{natval<D>()}, t:{moniker<T>()}";
        }

        public readonly struct CentralMask<F,D,T> : IMaskSpec<F,D,T>
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
        {
            public F f => default;

            public D d => default;

            public T t => default;

            public CentralMask<F,D,S> As<S>(S s = default)
                where S : unmanaged
                    => default;

            public override string ToString()
                => $"central, f:{natval<F>()}, d:{natval<D>()}, t:{moniker<T>()}";
        }

    }
}