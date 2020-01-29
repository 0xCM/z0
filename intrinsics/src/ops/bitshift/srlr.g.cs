//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        /// A register-based shift (as opposed to immediate-based) that shifts each source vector component rightwards 
        /// by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vsrlr<T>(Vector128<T> x, Vector128<T> count)
            where T : unmanaged
                => vsrlr_u(x,count);

        /// <summary>
        /// A register-based shift (as opposed to immediate-based) that shifts each source vector component rightwards 
        /// by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vsrlr<T>(Vector256<T> x, Vector256<T> count)
            where T : unmanaged
                => vsrlr_u(x,count);

        /// <summary>
        /// Shifts each source vector component rightwards by a specified offset via the register-based shift-right instruction
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vsrlr<T>(Vector128<T> x, T count)
            where T : unmanaged
                => vsrlr_u(x,count);

        /// <summary>
        /// Shifts each source vector component rightwards by a specified offset via the register-based shift-right instruction
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vsrlr<T>(Vector256<T> x, T count)
            where T : unmanaged
                => vsrlr_u(x,count);

        [MethodImpl(Inline)]
        static Vector128<T> vsrlr_u<T>(Vector128<T> x, Vector128<T> count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vsrlr(vcast8u(x), vcast8u(count)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsrlr(vcast16u(x), vcast16u(count)));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vsrlr(vcast32u(x), vcast32u(count)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vsrlr(vcast64u(x), vcast64u(count)));
            else 
                return vsrlr_i(x,count);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsrlr_i<T>(Vector128<T> x, Vector128<T> offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vsrlr(vcast8i(x), vcast8i(offset)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vsrlr(vcast16i(x), vcast16i(offset)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vsrlr(vcast32i(x), vcast32i(offset)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vsrlr(vcast64i(x), vcast64i(offset)));  
            else
                throw unsupported<T>();          
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsrlr_u<T>(Vector128<T> x, T offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vsrlr(vcast8u(x), uint8(offset)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsrlr(vcast16u(x), uint16(offset)));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vsrlr(vcast32u(x), uint32(offset)));
            else if(typeof(T) == typeof(ulong)) 
                return vgeneric<T>(dinx.vsrlr(vcast64u(x), uint64(offset)));
            else 
                return vsrlr_i(x,offset);                
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsrlr_i<T>(Vector128<T> x, T offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vsrlr(vcast8i(x), int8(offset)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vsrlr(vcast16i(x), int16(offset)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vsrlr(vcast32i(x), int32(offset)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vsrlr(vcast64i(x), int64(offset)));            
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsrlr_u<T>(Vector256<T> x, T offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vsrlr(vcast8u(x), uint8(offset)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsrlr(vcast16u(x), uint16(offset)));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vsrlr(vcast32u(x), uint32(offset)));
            else if(typeof(T) == typeof(ulong)) 
                return vgeneric<T>(dinx.vsrlr(vcast64u(x), uint64(offset)));
            else
                return vsrlr_i(x,offset);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsrlr_i<T>(Vector256<T> x, T offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vsrlr(vcast8i(x), int8(offset)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vsrlr(vcast16i(x), int16(offset)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vsrlr(vcast32i(x), int32(offset)));
            else if(typeof(T) == typeof(long)) 
                return vgeneric<T>(dinx.vsrlr(vcast64i(x), int64(offset)));            
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsrlr_u<T>(Vector256<T> x, Vector256<T> offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vsrlr(vcast8u(x), v8u(vlo(offset))));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsrlr(vcast16u(x), v16u(vlo(offset))));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vsrlr(vcast32u(x), v32u(vlo(offset))));
            else if(typeof(T) == typeof(ulong)) 
                return vgeneric<T>(dinx.vsrlr(vcast64u(x), v64u(vlo(offset))));
            else
                return vsrlr_i(x,offset);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsrlr_i<T>(Vector256<T> x, Vector256<T> offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vsrlr(vcast8i(x), v8i(vlo(offset))));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vsrlr(vcast16i(x), v16i(vlo(offset))));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vsrlr(vcast32i(x), v32i(vlo(offset))));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vsrlr(vcast64i(x), v64i(vlo(offset))));
            else
                throw unsupported<T>();
        }
    }
}