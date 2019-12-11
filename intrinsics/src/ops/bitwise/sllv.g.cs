//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static As;
    
    partial class ginx
    {        

        /// <summary>
        /// Computes z[i] := x[i] << s[i] for i = 0..n-1 where n is the vector component count
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vsllv<T>(Vector128<T> x, Vector128<T> offsets)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vsllv(v8u(x), v8u(offsets)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsllv(v16u(x), v16u(offsets)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vsllv(v32u(x), v32u(offsets)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vsllv(v64u(x), v64u(offsets)));            
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Computes z[i] := x[i] << s[i] for i = 0..n-1 where n is the vector component count
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vsllv<T>(Vector256<T> x, Vector256<T> offsets)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vsllv(v8u(x), v8u(offsets)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsllv(v16u(x), v16u(offsets)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vsllv(v32u(x), v32u(offsets)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vsllv(v64u(x), v64u(offsets)));            
            else
                throw unsupported<T>();
        }
    }
}