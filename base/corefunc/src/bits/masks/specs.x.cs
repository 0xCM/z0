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
    using static BitMask;
    partial class xfunc
    {
        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this LsbMask<N1,N1,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this LsbMask<N2,N1,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this LsbMask<N4,N1,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this LsbMask<N8,N1,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this LsbMask<N16,N1,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this LsbMask<N8,N2,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);
 
        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this LsbMask<N8,N3,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this LsbMask<N8,N4,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this LsbMask<N8,N5,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this LsbMask<N8,N6,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this LsbMask<N8,N7,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this MsbMask<N1,N1,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this MsbMask<N2,N1,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this MsbMask<N4,N1,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this MsbMask<N8,N1,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this MsbMask<N16,N1,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this MsbMask<N8,N2,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this MsbMask<N8,N3,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this MsbMask<N8,N4,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this MsbMask<N8,N5,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this MsbMask<N8,N6,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this MsbMask<N8,N7,T> spec)
            where T : unmanaged
                => msb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this JsbMask<N8,N1,T> spec)
            where T : unmanaged
                => jsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this JsbMask<N8,N2,T> spec)
            where T : unmanaged
                => jsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// Creates a mask from a specification
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this JsbMask<N8,N3,T> spec)
            where T : unmanaged
                => jsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [00011000]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this CentralMask<N8,N2,T> spec)
            where T : unmanaged
                => central(spec.f,spec.d, spec.t);

        /// <summary>
        /// [00111100]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this CentralMask<N8,N4,T> spec)
            where T : unmanaged
                => central(spec.f,spec.d, spec.t);

        /// <summary>
        /// [01111110]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T Mask<T>(this CentralMask<N8,N6,T> spec)
            where T : unmanaged
                => central(spec.f,spec.d, spec.t);

    }
}