//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    
    using static BitMask;
 
    partial class BitMaskX
    {
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


    }

}