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
        /// Computes x & (~y)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> vandnot<T>(in Vec128<T> x, in Vec128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vandnot(uint8(y), uint8(x)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vandnot(uint16(y),uint16(x)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vandnot(uint32(y), uint32(x)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vandnot(uint64(y), uint64(x)));
            else 
                throw unsupported<T>();
        }


        /// <summary>
        /// Computes x & (~y)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> vandnot<T>(in Vec256<T> x, in Vec256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vandnot(uint8(y),uint8(x)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vandnot(uint16(y),uint16(x)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vandnot(uint32(y), uint32(x)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vandnot(uint64(y), uint64(x)));
            else 
                throw unsupported<T>();
        }


    }
}