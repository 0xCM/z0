//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static Seed; 
    using static Memories;  
        
    static partial class vpattern
    {
        /// <summary>
        /// Creates a 128-bit vector with all bits enabled
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(NumericKind.All)]
        public static Vector128<T> vones<T>(N128 n, T t = default)
            where T : unmanaged
                => veq(default(Vector128<T>), default(Vector128<T>));

        /// <summary>
        /// Creates a 256-bit vector with all bits enabled
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(NumericKind.All)]
        public static Vector256<T> vones<T>(N256 n, T t = default)
            where T : unmanaged
                => veq(default(Vector256<T>), default(Vector256<T>));

        /// <summary>
        /// Creates a 512-bit vector with all bits enabled
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(NumericKind.All)]
        public static Vector512<T> vones<T>(N512 n, T t = default)
            where T : unmanaged
                => veq(default(Vector512<T>), default(Vector512<T>));

        [MethodImpl(Inline)]
        public static Vector128<T> vones<T>(Vec128Kind<T> kind)
            where T : unmanaged
                => vones<T>(w128);

        [MethodImpl(Inline)]
        public static Vector256<T> vones<T>(Vec256Kind<T> kind)
            where T : unmanaged
                => vones<T>(w256);
    }
}