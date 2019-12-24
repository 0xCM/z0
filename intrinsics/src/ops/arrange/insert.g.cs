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
    
    partial class ginx
    {
        /// <summary>
        /// Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vinsert<T>(Vector128<T> src, Vector256<T> dst, int index)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vinsert_u(src,dst,index);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vinsert_i(src,dst,index);
            else 
                return vinsert_f(src,dst,index);
        }


        [MethodImpl(Inline)]
        static Vector256<T> vinsert_i<T>(Vector128<T> src, Vector256<T> dst, int index)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vinsert(vcast8i(src), vcast8i(dst), index));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vinsert(vcast16i(src), vcast16i(dst), index));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vinsert(vcast32i(src), vcast32i(dst), index));
            else 
                return vgeneric<T>(dinx.vinsert(vcast64i(src), vcast64i(dst), index));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vinsert_u<T>(Vector128<T> src, Vector256<T> dst, int index)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vinsert(vcast8u(src), vcast8u(dst), index));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vinsert(vcast16u(src), vcast16u(dst), index));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vinsert(vcast64i(src), vcast64i(dst), index));
            else 
                return vgeneric<T>(dinx.vinsert(vcast64u(src), vcast64u(dst), index));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vinsert_f<T>(Vector128<T> src, Vector256<T> dst, int index)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vinsert(vcast32f(src), vcast32f(dst), index));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vinsert(vcast64f(src), vcast64f(dst), index));
            else
                throw unsupported<T>();
        } 

    }
}