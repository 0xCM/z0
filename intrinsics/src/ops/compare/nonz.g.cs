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
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;    
    using static As;
    
    partial class ginx
    {
        /// <summary>
        /// Returns true if at least one of the components of the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static bit vnonz<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vnonz_u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vnonz_i(src);
            else 
                return vnonz_f(src);
        }

        /// <summary>
        /// Returns true if at least one of the components of the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static bit vnonz<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vnonz_u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vnonz_i(src);
            else 
                return vnonz_f(src);
        }

        /// <summary>
        /// Returns true if at least one of the components of the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static bit vnonz<T>(in Vector512<T> src)
            where T : unmanaged
                => vnonz(src.Lo) || vnonz(src.Hi);       

        [MethodImpl(Inline)]
        static bit vnonz_i<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vnonz(vcast8i(src));
            else if(typeof(T) == typeof(short))
                return dinx.vnonz(vcast16i(src));
            else if(typeof(T) == typeof(int))
                return dinx.vnonz(vcast32i(src));
            else 
                return dinx.vnonz(vcast64i(src));
        }

        [MethodImpl(Inline)]
        static bit vnonz_u<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.vnonz(vcast8u(src));
            else if(typeof(T) == typeof(ushort))
                return dinx.vnonz(vcast16u(src));
            else if(typeof(T) == typeof(uint))
                return dinx.vnonz(vcast32u(src));
            else 
                return dinx.vnonz(vcast64u(src));
        }

        [MethodImpl(Inline)]
        static bit vnonz_f<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpinx.vnonz(vcast32f(src));
            else if(typeof(T) == typeof(double))
                return fpinx.vnonz(vcast64f(src));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static bit vnonz_i<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vnonz(vcast8i(src));
            else if(typeof(T) == typeof(short))
                return dinx.vnonz(vcast16i(src));
            else if(typeof(T) == typeof(int))
                return dinx.vnonz(vcast32i(src));
            else 
                return dinx.vnonz(vcast64i(src));
        }

        [MethodImpl(Inline)]
        static bit vnonz_u<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.vnonz(vcast8u(src));
            else if(typeof(T) == typeof(ushort))
                return dinx.vnonz(vcast16u(src));
            else if(typeof(T) == typeof(uint))
                return dinx.vnonz(vcast32u(src));
            else 
                return dinx.vnonz(vcast64u(src));
        }

        [MethodImpl(Inline)]
        static bit vnonz_f<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpinx.vnonz(vcast32f(src));
            else if(typeof(T) == typeof(double))
                return fpinx.vnonz(vcast64f(src));
            else 
                throw unsupported<T>();
        }
    }
}