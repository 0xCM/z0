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
    using static As;
    
    partial class ginx
    {
        /// <summary>
        /// Returns the number of T-components covered by a vector of a natural parametric width
        /// </summary>
        /// <param name="w">The vector width representative</param>
        /// <param name="t">The component type representative</param>
        /// <typeparam name="W">The vector bit width</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static int vcount<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
        {
            if(typeof(W) == typeof(N128))
                return Vector128<T>.Count;
            else if(typeof(W) == typeof(N256))
                return Vector256<T>.Count;
            else if(typeof(W) == typeof(N512))
                return Vector512<T>.Count;
            else
                return natval(w)/bitsize<T>();
        }            

        /// <summary>
        /// Returns the number of T-components covered by a 128-bit vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">The component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static int vcount<T>(N128 w = default, T t = default)
            where T : unmanaged
                => Vector128<T>.Count;

        /// <summary>
        /// Returns the number of T-components covered by a 256-bit vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">The component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static int vcount<T>(N256 w = default, T t = default)
            where T : unmanaged
                => Vector256<T>.Count;

        /// <summary>
        /// Returns the number of T-components covered by a 256-bit vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">The component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static int vcount<T>(N512 w = default, T t = default)
            where T : unmanaged
                => Vector512<T>.Count;

    }

}