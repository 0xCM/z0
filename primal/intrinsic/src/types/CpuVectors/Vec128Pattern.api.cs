//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Linq;

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;

    /// <summary>
    /// Defines an api for accessing/specifying 128-bit pattern vectors
    /// </summary>
    public static class Vec128Pattern
    {
        /// <summary>
        /// Returns an immutable reference to a vector where each component is assigned the numeric value 1
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        public static ref readonly Vec128<T> units<T>()
            where T : unmanaged
                => ref Vec128Pattern<T>.Units;

        /// <summary>
        /// Returns a vector with all bits turned on
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> ones<T>()
            where T : unmanaged                    
                 => ginx.vones128<T>();

        /// <summary>
        /// Returns a vector with all bits turned off
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> zeroes<T>()
            where T : unmanaged        
                => default;

        /// <summary>
        /// Creates a vector where each the component value at index i + 1, except the first, is obtained by 
        /// incrementing the value of the component at index i
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> increments<T>(T first = default, params Swap[] swaps)
            where T : unmanaged  
                => Vec128PatternData.increments<T>(first, swaps);

        /// <summary>
        /// Creates a vector where each the component value at index i + 1, except the first, is obtained by 
        /// decrementing the value of the component at index i
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <param name="swaps">Transpositions applied to the decreasing sequence prior to vector creation</param>
        /// <typeparam name="T">The primal component type</typeparam>        
        public static Vec128<T> decrements<T>(T first = default, params Swap[] swaps)
            where T : unmanaged  
                => Vec128Pattern<T>.Decrements(first, swaps);

        /// <summary>
        /// Creates a mask that, when applied to a source vector, effects a sequence of transpositions
        /// </summary>
        /// <param name="swaps">The transpositions</param>
        [MethodImpl(Inline)]
        public static Vec128<T> Swap<T>(params Swap[] swaps)
            where T : unmanaged  
                => Vec128Pattern<T>.Increments(default(T), swaps);

    }


}