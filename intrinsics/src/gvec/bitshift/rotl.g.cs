//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static Seed;
    using static Vectors;
    
    partial class gvec
    {
        /// <summary>
        /// Rotates each component the source vector leftwards by a constant amount
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The magnitude of the rotation</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector128<T> vrotl<T>(Vector128<T> x, [Imm] byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dvec.vrotl(v8u(x), count));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dvec.vrotl(v16u(x), count));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dvec.vrotl(v32u(x), count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dvec.vrotl(v64u(x), count));
            else
                throw Unsupported.define<T>();
        }

        /// <summary>
        /// Rotates each component the source vector leftwards by a constant count
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The magnitude of the rotation</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector256<T> vrotl<T>(Vector256<T> x, [Imm] byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dvec.vrotl(v8u(x), count));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dvec.vrotl(v16u(x), count));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dvec.vrotl(v32u(x), count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dvec.vrotl(v64u(x), count));
            else
                throw Unsupported.define<T>();
        }
    }
}