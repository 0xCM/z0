//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    public static partial class Reg
    {
        /// <summary>
        /// Moves source vector content to a 128-bit register target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target location</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static ref XMM move<T>(Vector128<T> src, ref XMM dst)
            where T : unmanaged
        {
            dst = XMM.From(src);
            return ref dst;
        }

        /// <summary>
        /// Moves source vector content to a 128-bit register/memory target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target location</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static ref XMEM move<T>(Vector128<T> src, ref XMEM dst)
            where T : unmanaged
        {
            dst = XMEM.From(src);
            return ref dst;
        }

        /// <summary>
        /// Moves source vector content to a 256-bit register target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target location</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static ref YMM move<T>(Vector256<T> src, ref YMM dst)
            where T : unmanaged
        {
            dst = YMM.From(src);
            return ref dst;
        }

        /// <summary>
        /// Moves source vector content to a 256-bit register/memory target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target location</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static ref YMEM move<T>(Vector256<T> src, ref YMEM dst)
            where T : unmanaged
        {
            dst = YMEM.From(src);
            return ref dst;
        }
    }
}