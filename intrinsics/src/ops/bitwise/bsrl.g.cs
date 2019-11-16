//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class ginx
    {

        /// <summary>
        /// Shifts the source vector rightwards a specified number of bytes
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vbsrl<T>(Vector128<T> x, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vbsrl(uint8(x), count));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vbsrl(uint16(x), count));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vbsrl(uint32(x), count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vbsrl(uint64(x), count));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Shifts the source vector rightwards a specified number of bytes
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vbsrl<T>(Vector256<T> x, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vbsrl(uint8(x), count));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vbsrl(uint16(x), count));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vbsrl(uint32(x), count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vbsrl(uint64(x), count));
            else
                throw unsupported<T>();
        }
    }

}