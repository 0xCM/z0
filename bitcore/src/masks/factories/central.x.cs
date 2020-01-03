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

    public static partial class BitMaskX
    {                
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