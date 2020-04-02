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
    
    using static Core;
    using static VCore;

    partial class gvec
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vblend4x32<T>(Vector128<T> x, Vector128<T> y, [Imm] byte spec)        
            where T : unmanaged
                => vblend4x32_u(x,y,spec);

        /// <summary>
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vblend8x32<T>(Vector256<T> x, Vector256<T> y, [Imm] byte spec)        
            where T : unmanaged
                => vblend8x32_u(x,y,spec);

        [MethodImpl(Inline)]
        public static Vector128<T> vblend<T>(Vector128<T> x, Vector128<T> y, Blend4x32 spec)        
            where T : unmanaged
                => vblend4x32(x,y,(byte)spec);

        /// <summary>
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vblend<T>(Vector256<T> x, Vector256<T> y, Blend8x32 spec)        
            where T : unmanaged
                => vblend8x32(x,y,(byte)spec);

        [MethodImpl(Inline)]
        static Vector128<T> vblend4x32_u<T>(Vector128<T> x, Vector128<T> y, byte spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(v8u(dvec.vblend4x32(v32u(x), v32u(y), spec)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(v16u(dvec.vblend4x32(v32u(x), v32u(y), spec)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dvec.vblend4x32(v32u(x), v32u(y), spec));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(v64u(dvec.vblend4x32(v32u(x), v32u(y), spec)));
            else
                return vblend4x32_i(x, y, spec);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vblend4x32_i<T>(Vector128<T> x, Vector128<T> y, byte spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(v8i(dvec.vblend4x32(v32u(x), v32u(y), spec)));
            else if(typeof(T) == typeof(short))
                return generic<T>(v16i(dvec.vblend4x32(v32u(x), v32u(y), spec)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dvec.vblend4x32(v32i(x), v32i(y), spec));
            else if(typeof(T) == typeof(long))
                return generic<T>(v64i(dvec.vblend4x32(v32u(x), v32u(y), spec)));
            else 
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vblend8x32_u<T>(Vector256<T> x, Vector256<T> y, byte spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(v8u(dvec.vblend8x32(v32u(x), v32u(y), spec)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(v16u(dvec.vblend8x32(v32u(x), v32u(y), spec)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dvec.vblend8x32(v32u(x), v32u(y), spec));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(v64u(dvec.vblend8x32(v32u(x), v32u(y), spec)));
            else
                return vblend8x32_i(x, y, spec);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vblend8x32_i<T>(Vector256<T> x, Vector256<T> y, byte spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(v8i(dvec.vblend8x32(v32u(x), v32u(y), spec)));
            else if(typeof(T) == typeof(short))
                return generic<T>(v16i(dvec.vblend8x32(v32u(x), v32u(y), spec)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dvec.vblend8x32(v32i(x), v32i(y), spec));
            else if(typeof(T) == typeof(long))
                return generic<T>(v64i(dvec.vblend8x32(v32u(x), v32u(y), spec)));
            else 
                throw Unsupported.define<T>();
        }
    }
}