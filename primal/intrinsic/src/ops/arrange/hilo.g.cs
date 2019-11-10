//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    
    using static zfunc;    
    using static AsIn;    
    using static As;

    partial class ginx
    {        
        /// <summary>
        /// Extracts the lo 128-bit lane of the source vector to scalar targets
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static void vlo<T>(Vector256<T> src, out ulong x0, out ulong x1)
            where T : unmanaged
                => dinx.vlo(src.AsUInt64(), out x0, out x1);

        /// <summary>
        /// Extracts the hi 128-bit lane of the source vector to scalar targets
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static void vhi<T>(Vector256<T> src, out ulong x0, out ulong x1)
            where T : unmanaged
                => dinx.vhi(src.AsUInt64(), out x0, out x1);

        /// <summary>
        /// Extracts the hi 128-bit lane of the source vector to a pair
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static ref Pair<ulong> vhi<T>(Vector256<T> src, ref Pair<ulong> dst)
            where T : unmanaged
                => ref dinx.vhi(src.AsUInt64(), ref dst);

        /// <summary>
        /// Extracts the lo 128-bit lane of the source vector to a pair
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static ref Pair<ulong> vlo<T>(Vector256<T> src, ref Pair<ulong> dst)
            where T : unmanaged        
                => ref dinx.vlo(src.AsUInt64(), ref dst);

        /// <summary>
        /// Extracts the lo 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vlo<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vlo_u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vlo_i(src);
            else 
                throw unsupported<T>();
        }

         /// <summary>
        /// Extracts hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vhi<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vhi_u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vhi_i(src);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vec128<T> vhi_i<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vhi(int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vhi(int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vhi(int32(src)));
            else
                return generic<T>(dinx.vhi(int64(src)));
        }

        [MethodImpl(Inline)]
        static Vec128<T> vhi_u<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vhi(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vhi(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vhi(uint32(src)));
            else 
                return generic<T>(dinx.vhi(uint64(src)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vlo_i<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vlo(int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vlo(int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vlo(int32(src)));
            else
                return generic<T>(dinx.vlo(int64(src)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vlo_u<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vlo(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vlo(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vlo(uint32(src)));
            else 
                return generic<T>(dinx.vlo(uint64(src)));
        }
         
    }
}