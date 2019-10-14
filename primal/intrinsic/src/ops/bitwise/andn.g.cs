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
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
         [MethodImpl(Inline)]
        public static Vec128<T> vandn<T>(in Vec128<T> x, in Vec128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vandn(uint8(x), uint8(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vandn(uint16(x), uint16(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vandn(uint32(x), uint32(y)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vandn(uint64(x), uint64(y)));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> vandn<T>(Vec256<T> x, Vec256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vandn(uint8(x), uint8(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vandn(uint16(x), uint16(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vandn(uint32(x), uint32(y)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vandn(uint64(x), uint64(y)));
            else 
                throw unsupported<T>();
        }

 
    }
}