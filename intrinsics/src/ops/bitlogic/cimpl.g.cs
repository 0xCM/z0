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
    
    using static zfunc;    
    using static As;
    
    partial class ginx
    {
        /// <summary>
        /// Computes the converse implication, ~x | y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vcimpl<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vcimpl(vcast8u(x), vcast8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vcimpl(vcast16u(x),vcast16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vcimpl(vcast32u(x), vcast32u(y)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vcimpl(vcast64u(x), vcast64u(y)));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Computes the converse implication, ~x | y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vcimpl<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vcimpl(vcast8u(x), vcast8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vcimpl(vcast16u(x),vcast16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vcimpl(vcast32u(x), vcast32u(y)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vcimpl(vcast64u(x), vcast64u(y)));
            else 
                throw unsupported<T>();
        }
    }
}