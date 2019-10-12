//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

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
        public static ref readonly Vec128<T> Units<T>()
            where T : unmanaged
                => ref Vec128Pattern<T>.Units;

        /// <summary>
        /// Returns an immutable reference to a vector with all bits turned on
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        public static ref readonly Vec128<T> AllOnes<T>()
            where T : unmanaged
                => ref Vec128Pattern<T>.AllOnes;

        /// <summary>
        /// Creates a vector where each the component value at index i + 1, except the first, is obtained by 
        /// incrementing the value of the component at index i
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec128<T> Increments<T>(T first = default, params Swap[] swaps)
            where T : unmanaged  
                => Vec128Pattern<T>.Increments(first,swaps);

        /// <summary>
        /// Creates a vector where each the component value at index i + 1, except the first, is obtained by 
        /// decrementing the value of the component at index i
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <param name="swaps">Transpositions applied to the decreasing sequence prior to vector creation</param>
        /// <typeparam name="T">The primal component type</typeparam>        
        public static Vec128<T> Decrements<T>(T first = default, params Swap[] swaps)
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
 
        /// <summary>
        /// Creates a vector with components that increase by a specified step
        /// </summary>
        /// <param name="start">The value of the first component</param>
        /// <param name="step">The distance between components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec128<T> Increasing<T>(T start, T step)
            where T : unmanaged
        {
            var n = Vec128<T>.Length;
            var current = start;
            var dst = Span256.AllocBlock<T>();
            for(var i=0; i<n; i++)
            {
                dst[i] = current;
                gmath.add(ref current, step);
            }
            return Vec128.Load(ref head(dst));

        }

    }


}