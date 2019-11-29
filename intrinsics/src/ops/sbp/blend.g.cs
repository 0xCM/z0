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
    
    using static As;
    using static zfunc;

    partial class ginx
    {
        /// <summary>
        /// Forms a vector z[i] = testbit(spec[i],7) ? x[i] : y[i] where i = 0,...31
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vblend32x8<T>(Vector256<T> x, Vector256<T> y, Vector256<byte> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vblend32x8_u(x, y, spec);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vblend32x8_i(x, y, spec);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Forms a vector z[i] = testbit(spec[i],7) ? x[i] : y[i] where i = 0,...15
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vblend16x8<T>(Vector128<T> x, Vector128<T> y, Vector128<byte> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vblend16x8_u(x, y, spec);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vblend16x8_i(x, y, spec);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vblend8x32<T>(Vector256<T> x, Vector256<T> y, Blend8x32 spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vblend8x32_u(x, y, spec);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vblend8x32_i(x, y, spec);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vblend8x16<T>(Vector128<T> x, Vector128<T> y, Blend8x16 spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vblend8x16_u(x, y, spec);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vblend8x16_i(x, y, spec);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vblend8x16<T>(Vector256<T> x, Vector256<T> y, Blend8x16 spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vblend8x16_u(x, y, spec);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vblend8x16_i(x, y, spec);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vblend4x32<T>(Vector128<T> x, Vector128<T> y, Blend4x32 spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vblend4x32_u(x, y, spec);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vblend4x32_i(x, y, spec);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vblend32x8_u<T>(Vector256<T> x, Vector256<T> y, Vector256<byte> spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vblend32x8(vcast8u(x), vcast8u(y), spec));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vblend32x8(vcast16u(x), vcast16u(y), spec));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vblend32x8(vcast32u(x), vcast32u(y), spec));
            else
                return vgeneric<T>(dinx.vblend32x8(vcast64u(x), vcast64u(y), spec));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vblend32x8_i<T>(Vector256<T> x, Vector256<T> y, Vector256<byte> spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vblend32x8(vcast8i(x), vcast8i(y), spec));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vblend32x8(vcast16i(x), vcast16i(y), spec));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vblend32x8(vcast32i(x), vcast32i(y), spec));
            else
                return vgeneric<T>(dinx.vblend32x8(vcast64i(x), vcast64i(y), spec));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vblend8x32_u<T>(Vector256<T> x, Vector256<T> y, Blend8x32 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vblend8x32(vcast8u(x), vcast8u(y), spec));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vblend8x32(vcast16u(x), vcast16u(y), spec));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vblend8x32(vcast32u(x), vcast32u(y), spec));
            else
                return vgeneric<T>(dinx.vblend8x32(vcast64u(x), vcast64u(y), spec));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vblend8x32_i<T>(Vector256<T> x, Vector256<T> y, Blend8x32 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vblend8x32(vcast8i(x), vcast8i(y), spec));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vblend8x32(vcast16i(x), vcast16i(y), spec));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vblend8x32(vcast32i(x), vcast32i(y), spec));
            else
                return vgeneric<T>(dinx.vblend8x32(vcast64i(x), vcast64i(y), spec));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vblend16x8_u<T>(Vector128<T> x, Vector128<T> y, Vector128<byte> spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vblend16x8(vcast8u(x), vcast8u(y), spec));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vblend16x8(vcast16u(x), vcast16u(y), spec));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vblend16x8(vcast32u(x), vcast32u(y), spec));
            else
                return vgeneric<T>(dinx.vblend16x8(vcast64u(x), vcast64u(y), spec));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vblend16x8_i<T>(Vector128<T> x, Vector128<T> y, Vector128<byte> spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return As.vgeneric<T>(dinx.vblend16x8(vcast8i(x), vcast8i(y), spec));
            else if(typeof(T) == typeof(short))
                return As.vgeneric<T>(dinx.vblend16x8(vcast16i(x), vcast16i(y), spec));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vblend16x8(vcast32i(x), vcast32i(y), spec));
            else
                return vgeneric<T>(dinx.vblend16x8(vcast64i(x), vcast64i(y), spec));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vblend8x16_u<T>(Vector128<T> x, Vector128<T> y, Blend8x16 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vblend8x16(vcast8u(x), vcast8u(y), spec));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vblend8x16(vcast16u(x), vcast16u(y), spec));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vblend8x16(vcast32u(x), vcast32u(y), spec));
            else
                return vgeneric<T>(dinx.vblend8x16(vcast64u(x), vcast64u(y), spec));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vblend8x16_i<T>(Vector128<T> x, Vector128<T> y, Blend8x16 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return As.vgeneric<T>(dinx.vblend8x16(vcast8i(x), vcast8i(y), spec));
            else if(typeof(T) == typeof(short))
                return As.vgeneric<T>(dinx.vblend8x16(vcast16i(x), vcast16i(y), spec));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vblend8x16(vcast32i(x), vcast32i(y), spec));
            else
                return vgeneric<T>(dinx.vblend8x16(vcast64i(x), vcast64i(y), spec));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vblend8x16_u<T>(Vector256<T> x, Vector256<T> y, Blend8x16 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vblend8x16(vcast8u(x), vcast8u(y), spec));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vblend8x16(vcast16u(x), vcast16u(y), spec));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vblend8x16(vcast32u(x), vcast32u(y), spec));
            else
                return vgeneric<T>(dinx.vblend8x16(vcast64u(x), vcast64u(y), spec));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vblend8x16_i<T>(Vector256<T> x, Vector256<T> y, Blend8x16 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vblend8x16(vcast8i(x), vcast8i(y), spec));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vblend8x16(vcast16i(x), vcast16i(y), spec));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vblend8x16(vcast32i(x), vcast32i(y), spec));
            else
                return vgeneric<T>(dinx.vblend8x16(vcast64i(x), vcast64i(y), spec));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vblend4x32_i<T>(Vector128<T> x, Vector128<T> y, Blend4x32 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return As.vgeneric<T>(dinx.vblend4x32(vcast8i(x), vcast8i(y), spec));
            else if(typeof(T) == typeof(short))
                return As.vgeneric<T>(dinx.vblend4x32(vcast16i(x), vcast16i(y), spec));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vblend4x32(vcast32i(x), vcast32i(y), spec));
            else
                return vgeneric<T>(dinx.vblend4x32(vcast64i(x), vcast64i(y), spec));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vblend4x32_u<T>(Vector128<T> x, Vector128<T> y, Blend4x32 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vblend4x32(vcast8u(x), vcast8u(y), spec));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vblend4x32(vcast16u(x), vcast16u(y), spec));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vblend4x32(vcast32u(x), vcast32u(y), spec));
            else
                return vgeneric<T>(dinx.vblend4x32(vcast64u(x), vcast64u(y), spec));
        }

    }
}