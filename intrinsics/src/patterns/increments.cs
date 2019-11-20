//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Linq;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;
    
    partial class ginx
    {
        [MethodImpl(Inline)]
        public static Vector128<T> vincrements<T>(N128 n)
            where T : unmanaged
                => DataPatterns.increments<T>(n);

        [MethodImpl(Inline)]
        public static Vector256<T> vincrements<T>(N256 n)
            where T : unmanaged
                => DataPatterns.increments<T>(n);

        /// <summary>
        /// Creates a 128-bit vector with components that increase by unit step from an initial value
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vincrements<T>(N128 n, T first)
            where T : unmanaged
        {
            var current = first;
            var data = MemBlocks.alloc<T>(n);
            var len = MemBlocks.blocklen<T>(n);
            ref var mem = ref head(data);
            for(var i=0; i<len; i++)
            {
                seek(ref mem, i) = current;
                gmath.inc(ref current);
            }

            return vload(n, in mem);
        }


        /// <summary>
        /// Creates a 256-bit vector with components that increase by unit step from an initial value
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vincrements<T>(N256 n, T first)
            where T : unmanaged
        {
            var current = first;
            var data = MemBlocks.alloc<T>(n);
            var len = MemBlocks.blocklen<T>(n);
            ref var mem = ref head(data);
            for(var i=0; i<len; i++)
            {
                seek(ref mem, i) = current;
                gmath.inc(ref current);
            }

            return vload(n, in mem);
        }            


    }

}