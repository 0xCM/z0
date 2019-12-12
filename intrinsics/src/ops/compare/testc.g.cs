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
        /// Determines whether all source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static bit vtestc<T>(Vector128<T> src)
            where T : unmanaged
                => vtestc(src, vbuild.ones<T>(n128));
        
        /// <summary>
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static bit vtestc<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vtestc_u(src,mask);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vtestc_i(src,mask);
            else 
                return vtestc_f(src,mask);
        }
        
        /// <summary>
        /// Returns true if all bits in the source vector are enabled, false otherwise
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static bit vtestc<T>(Vector256<T> src)
            where T : unmanaged
                => vtestc(src, vbuild.ones<T>(n256));        

        /// <summary>
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static bit vtestc<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vtestc_u(src,mask);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vtestc_i(src,mask);
            else 
                return vtestc_f(src,mask);
        }

        /// <summary>
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        static bit vtestc_i<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vtestc(vcast8i(src), vcast8i(mask));
            else if(typeof(T) == typeof(short))
                return dinx.vtestc(vcast16i(src), vcast16i(mask));
            else if(typeof(T) == typeof(int))
                return dinx.vtestc(vcast32i(src), vcast32i(mask));
            else 
                return dinx.vtestc(vcast64i(src), vcast64i(mask));
        }

        /// <summary>
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        static bit vtestc_u<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.vtestc(vcast8u(src), vcast8u(mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.vtestc(vcast16u(src), vcast16u(mask));
            else if(typeof(T) == typeof(uint))
                return dinx.vtestc(vcast32u(src), vcast32u(mask));
            else 
                return dinx.vtestc(vcast64u(src), vcast64u(mask));
        }


        /// <summary>
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        static bit vtestc_f<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpinx.vtestc(vcast32f(src), vcast32f(mask));
            else if(typeof(T) == typeof(double))
                return fpinx.vtestc(vcast64f(src), vcast64f(mask));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static bit vtestc_i<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vtestc(vcast8i(src), vcast8i(mask));
            else if(typeof(T) == typeof(short))
                return dinx.vtestc(vcast16i(src), vcast16i(mask));
            else if(typeof(T) == typeof(int))
                return dinx.vtestc(vcast32i(src), vcast32i(mask));
            else 
                return dinx.vtestc(vcast64i(src), vcast64i(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestc_u<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.vtestc(vcast8u(src), vcast8u(mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.vtestc(vcast16u(src), vcast16u(mask));
            else if(typeof(T) == typeof(uint))
                return dinx.vtestc(vcast32u(src), vcast32u(mask));
            else 
                return dinx.vtestc(vcast64u(src), vcast64u(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestc_f<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpinx.vtestc(vcast32f(src), vcast32f(mask));
            else if(typeof(T) == typeof(double))
                return fpinx.vtestc(vcast64f(src), vcast64f(mask));
            else 
                throw unsupported<T>();
        }
    }
}