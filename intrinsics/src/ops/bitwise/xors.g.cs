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
    
    using static As;
    using static zfunc;

    partial class ginx
    {
        /// <summary>
        /// Computes x ^ ((x << offset) ^ (x >> offset));
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">The shift offset</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vxors<T>(Vector128<T> x, byte offset)
            where T : unmanaged
                => vxor(x,vxor(vsll(x, offset),vsrl(x,offset)));

        /// <summary>
        /// Computes x ^ ((x << offset) ^ (x >> offset));
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">The shift offset</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vxors<T>(Vector256<T> x, byte offset)
            where T : unmanaged
                => vxor(x,vxor(vsll(x, offset),vsrl(x,offset)));


        /// <summary>
        /// Computes x^(x >> offset)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vxorsr<T>(Vector128<T> x, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vxorsr(uint8(x), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vxorsr(uint16(x), offset));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vxorsr(uint32(x), offset));
            else 
                return generic<T>(dinx.vxorsr(uint64(x), offset));
        }

        /// <summary>
        /// Computes x^(x >> offset)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vxorsr<T>(Vector256<T> x, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vxorsr(uint8(x), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vxorsr(uint16(x), offset));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vxorsr(uint32(x), offset));
            else 
                return generic<T>(dinx.vxorsr(uint64(x), offset));
        }

        /// <summary>
        /// Computes x^(x << offset)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vxorsl<T>(Vector128<T> x, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vxorsl(uint8(x), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vxorsl(uint16(x), offset));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vxorsl(uint32(x), offset));
            else 
                return generic<T>(dinx.vxorsl(uint64(x), offset));
        }

        /// <summary>
        /// Computes x^(x << offset)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vxorsl<T>(Vector256<T> x, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vxorsl(uint8(x), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vxorsl(uint16(x), offset));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vxorsl(uint32(x), offset));
            else 
                return generic<T>(dinx.vxorsl(uint64(x), offset));
        }
    }
}
