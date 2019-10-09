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
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
         [MethodImpl(Inline)]
        public static Vec128<T> vandn<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vandn(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vandn(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vandn(uint32(lhs), uint32(rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vandn(uint64(lhs), uint64(rhs)));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> vandn<T>(Vec256<T> lhs, Vec256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vandn(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vandn(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vandn(uint32(lhs), uint32(rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vandn(uint64(lhs), uint64(rhs)));
            else 
                throw unsupported<T>();
        }
    }
}