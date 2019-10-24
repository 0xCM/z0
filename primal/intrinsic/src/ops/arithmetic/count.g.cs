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
        /// Increments each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> vnext<T>(in Vec128<T> src)
            where T : unmanaged
                => vadd<T>(src, Vec128Pattern.units<T>());

        /// <summary>
        /// Increments each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> vnext<T>(in Vec256<T> src)
            where T : unmanaged
                => vadd<T>(src, Vec256Pattern.Units<T>());

        /// <summary>
        /// Increments each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vnext<T>(Vector128<T> src)
            where T : unmanaged
                => vadd<T>(src, Vec128Pattern.units<T>());

        /// <summary>
        /// Increments each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vnext<T>(Vector256<T> src)
            where T : unmanaged
                => vadd<T>(src, Vec256Pattern.Units<T>());

        /// <summary>
        /// Decrements each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> vprior<T>(in Vec128<T> src)
            where T : unmanaged
                => vsub<T>(src, Vec128Pattern.units<T>());

        /// <summary>
        /// Decrements each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> vprior<T>(in Vec256<T> src)
            where T : unmanaged
                => vsub<T>(src, Vec256Pattern.Units<T>());

        /// <summary>
        /// Decrements each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vprior<T>(Vector128<T> src)
            where T : unmanaged
                => vsub<T>(src, Vec128Pattern.units<T>());

        /// <summary>
        /// Decrements each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vprior<T>(Vector256<T> src)
            where T : unmanaged
                => vsub<T>(src, Vec256Pattern.Units<T>());

    }

}