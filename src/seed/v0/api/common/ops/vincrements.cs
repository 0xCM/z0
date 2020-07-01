//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    
    using static Konst;

    partial struct V0
    {        
        /// <summary>
        /// Creates a 128-bit vector with component values 0, 1, ... k - 1 where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vincrements<T>(W128 w)
            where T : unmanaged
                => V0p.vincrements<T>(w);       

        /// <summary>
        /// Creates a 256-bit vector with component values 0, 1, ... k - 1 where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vincrements<T>(W256 w)
            where T : unmanaged
                => V0p.vincrements<T>(w);       

        /// <summary>
        /// Creates a 256-bit vector with component values 0, 1, ... k - 1 where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> vincrements<T>(W512 w)
            where T : unmanaged
                => V0p.vincrements<T>(w);       
    }
}