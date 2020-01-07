//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    
    using static zfunc;    
    using static As;

    partial class ginx
    {        
        /// <summary>
        /// Moves the hi 64 bits of the source vector the the lo 64 bits of a target vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
        public static Vector128<T> vhi<T>(Vector128<T> src)
            where T : unmanaged
                => vgeneric<T>(CpuVector.vscalar(n128, vcell(v64u(src),1)));

        /// <summary>
        /// Extracts hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
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
                return vhi_f(src);
        }

        /// <summary>
        /// Extracts the hi 128-bit lane of the source vector to scalar targets
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
        public static void vhi<T>(Vector256<T> src, out ulong x0, out ulong x1)
            where T : unmanaged
                => dinx.vhi(v64u(src), out x0, out x1);

        /// <summary>
        /// Extracts the hi 128-bit lane of the source vector to a pair
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
        public static ref Pair<ulong> vhi<T>(Vector256<T> src, ref Pair<ulong> dst)
            where T : unmanaged
                => ref dinx.vhi(src.AsUInt64(), ref dst);

        /// <summary>
        /// Extracts the upper 256-bits from the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
        public static Vector256<T> vhi<T>(Vector512<T> src)
            where T : unmanaged
                => src.Hi;       

        /// <summary>
        /// Extracts the lower 256-bits from the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
        public static Vector512<T> vhi<T>(Vector1024<T> src)
            where T : unmanaged
                => src.Hi;       

        [MethodImpl(Inline)]
        static Vector128<T> vhi_u<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vhi(vcast8u(src)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vhi(vcast16u(src)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vhi(vcast32u(src)));
            else 
                return vgeneric<T>(dinx.vhi(vcast64u(src)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vhi_i<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vhi(vcast8i(src)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vhi(vcast16i(src)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vhi(vcast32i(src)));
            else
                return vgeneric<T>(dinx.vhi(vcast64i(src)));
        }


        [MethodImpl(Inline)]
        static Vector128<T> vhi_f<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vhi(vcast32f(src)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vhi(vcast64f(src)));
            else 
                throw unsupported<T>();
        }
    }
}