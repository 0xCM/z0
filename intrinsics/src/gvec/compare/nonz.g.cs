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

    using static Root;    
    using static vgeneric;
    
    partial class gvec
    {
        /// <summary>
        /// Returns true if at least one of the components of the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
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
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
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
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static bit vnonz<T>(in Vector512<T> src)
            where T : unmanaged
                => vnonz(src.Lo) || vnonz(src.Hi);       

        [MethodImpl(Inline)]
        static bit vnonz_i<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dvec.vnonz(v8i(src));
            else if(typeof(T) == typeof(short))
                return dvec.vnonz(v16i(src));
            else if(typeof(T) == typeof(int))
                return dvec.vnonz(v32i(src));
            else 
                return dvec.vnonz(v64i(src));
        }

        [MethodImpl(Inline)]
        static bit vnonz_u<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dvec.vnonz(v8u(src));
            else if(typeof(T) == typeof(ushort))
                return dvec.vnonz(v16u(src));
            else if(typeof(T) == typeof(uint))
                return dvec.vnonz(v32u(src));
            else 
                return dvec.vnonz(v64u(src));
        }

        [MethodImpl(Inline)]
        static bit vnonz_f<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxfp.vnonz(v32f(src));
            else if(typeof(T) == typeof(double))
                return dinxfp.vnonz(v64f(src));
            else 
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        static bit vnonz_i<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dvec.vnonz(v8i(src));
            else if(typeof(T) == typeof(short))
                return dvec.vnonz(v16i(src));
            else if(typeof(T) == typeof(int))
                return dvec.vnonz(v32i(src));
            else 
                return dvec.vnonz(v64i(src));
        }

        [MethodImpl(Inline)]
        static bit vnonz_u<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dvec.vnonz(v8u(src));
            else if(typeof(T) == typeof(ushort))
                return dvec.vnonz(v16u(src));
            else if(typeof(T) == typeof(uint))
                return dvec.vnonz(v32u(src));
            else 
                return dvec.vnonz(v64u(src));
        }

        [MethodImpl(Inline)]
        static bit vnonz_f<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxfp.vnonz(v32f(src));
            else if(typeof(T) == typeof(double))
                return dinxfp.vnonz(v64f(src));
            else 
                throw Unsupported.define<T>();
        }
    }
}