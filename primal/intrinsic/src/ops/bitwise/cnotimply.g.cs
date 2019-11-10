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
    using static AsIn;
    
    partial class ginx
    {
        /// <summary>
        /// Computes the converse nonimplication, x & (~y)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vcnotimply<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vcnotimply(uint8(x), uint8(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vcnotimply(uint16(x),uint16(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vcnotimply(uint32(x), uint32(y)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vcnotimply(uint64(x), uint64(y)));
            else 
                throw unsupported<T>();
        }


        /// <summary>
        /// Computes the converse nonimplication, x & (~y)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vcnotimply<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vcnotimply(uint8(x), uint8(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vcnotimply(uint16(x),uint16(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vcnotimply(uint32(x), uint32(y)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vcnotimply(uint64(x), uint64(y)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vcnotimply<T>(N128 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(in rX, out Vector128<T> vA);
            vload(in rY, out Vector128<T> vB);
            return vcnotimply(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void vcnotimply<T>(N128 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
                => vstore(vcnotimply(n, in rX, in rY), ref rDst);

        [MethodImpl(Inline)]
        public static Vector256<T> vcnotimply<T>(N256 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(in rX, out Vector256<T> vA);
            vload(in rY, out Vector256<T> vB);
            return vcnotimply(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void vcnotimply<T>(N256 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
                => vstore(vcnotimply(n, in rX, in rY), ref rDst);
    }
}