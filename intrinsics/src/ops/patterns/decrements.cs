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


        /// <summary>
        /// Creates a 128-bit vector with components that decrease by uint step from an initial value
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vdecrements<T>(N128 n, T first)
            where T : unmanaged
        {
            var current = first;
            var data = BlockedSpan.alloc<T>(n);
            var len = BlockedSpan.blocklen<T>(n);
            ref var mem = ref head(data);
            for(var i=0; i < len; i++)
            {
                seek(ref mem, i) = current;
                gmath.dec(ref current);
            }
                        
            return ginx.vload(n, in mem);
        }    

        /// <summary>
        /// Creates a 128-bit vector with components that decrease by uint step from an initial value
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vdecrements<T>(N256 n, T first)
            where T : unmanaged
        {
            var current = first;
            var data = BlockedSpan.alloc<T>(n);
            var len = BlockedSpan.blocklen<T>(n);
            ref var mem = ref head(data);
            for(var i=0; i < len; i++)
            {
                seek(ref mem, i) = current;
                gmath.dec(ref current);
            }
                        
            return ginx.vload(n, in mem);
        }    


        /// <summary>
        /// Creates a 128-bit vector with components that decrease by a specified step from an initial value
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vdecrements<T>(N128 n, T first, T step)
            where T : unmanaged
        {
            var current = first;
            var data = BlockedSpan.alloc<T>(n);
            var len = BlockedSpan.blocklen<T>(n);
            ref var mem = ref head(data);
            for(var i=0; i < len; i++)
            {
                seek(ref mem, i) = current;
                gmath.sub(ref current, step);
            }
            return vload(n, in mem);
        }

        /// <summary>
        /// Creates a 256-bit vector with components that decrease by a specified step from an initial value
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vdecrements<T>(N256 n, T first, T step)
            where T : unmanaged
        {
            var current = first;
            var data = BlockedSpan.alloc<T>(n);
            var len = BlockedSpan.blocklen<T>(n);
            ref var mem = ref head(data);
            for(var i=0; i < len; i++)
            {
                seek(ref mem, i) = current;
                gmath.sub(ref current, step);
            }
            return vload(n, in mem);
        }

        public static Vector256<T> vdecrements<T>(N256 n, T first, params Swap[] swaps)
            where T : unmanaged
        {
            var current = first;
            var data = BlockedSpan.alloc<T>(n);
            var len = BlockedSpan.blocklen<T>(n);
            ref var mem = ref head(data);
            for(var i=0; i < len; i++)
            {
                seek(ref mem, i) = current;
                gmath.dec(ref current);
            }

            return ginx.vload(n, in head(data.Swap(swaps)));
        }            

        public static Vector128<T> vdecrements<T>(N128 n, T first, params Swap[] swaps)
            where T : unmanaged
        {
            var current = first;
            var data = BlockedSpan.alloc<T>(n);
            var len = BlockedSpan.blocklen<T>(n);
            ref var mem = ref head(data);
            for(var i=0; i < len; i++)
            {
                seek(ref mem, i) = current;
                gmath.dec(ref current);
            }

            return ginx.vload(n, in head(data.Swap(swaps)));
        }    
    }
}