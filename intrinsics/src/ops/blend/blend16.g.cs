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
    
    using static As;
    using static zfunc;

    partial class ginx
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vblend8x16<T>(Vector128<T> x, Vector128<T> y, [Imm] byte spec)        
            where T : unmanaged
                => vblend8x16_u(x, y, spec);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vblend8x16<T>(Vector256<T> x, Vector256<T> y, [Imm] byte spec)        
            where T : unmanaged
                => vblend8x16_u(x, y, spec);

        [MethodImpl(Inline)]
        public static Vector128<T> vblend<T>(Vector128<T> x, Vector128<T> y, [Imm] Blend8x16 spec)        
            where T : unmanaged
                => vblend8x16_u(x, y, (byte)spec);

        [MethodImpl(Inline)]
        public static Vector256<T> vblend<T>(Vector256<T> x, Vector256<T> y, [Imm] Blend8x16 spec)        
            where T : unmanaged
                => vblend8x16_u(x, y, (byte)spec);

        [MethodImpl(Inline)]
        static Vector128<T> vblend8x16_u<T>(Vector128<T> x, Vector128<T> y, byte spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(v8u(dinx.vblend8x16(v16u(x), v16u(y), spec)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vblend8x16(v16u(x), v16u(y), spec));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(v32u(dinx.vblend8x16(v16u(x), v16u(y), spec)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(v64u(dinx.vblend8x16(v16u(x), v16u(y), spec)));
            else
                return vblend8x16_i(x,y,spec);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vblend8x16_i<T>(Vector128<T> x, Vector128<T> y, byte spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(v8i(dinx.vblend8x16(v16u(x), v16u(y), spec)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vblend8x16(v16i(x), v16i(y), spec));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(v32i(dinx.vblend8x16(v16u(x), v16u(y), spec)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(v64i(dinx.vblend8x16(v16u(x), v16u(y), spec)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vblend8x16_u<T>(Vector256<T> x, Vector256<T> y, byte spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(v8u(dinx.vblend8x16(v16u(x), v16u(y), spec)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vblend8x16(v16u(x), v16u(y), spec));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(v32u(dinx.vblend8x16(v16u(x), v16u(y), spec)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(v64u(dinx.vblend8x16(v16u(x), v16u(y), spec)));
            else
                return vblend8x16_i(x,y,spec);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vblend8x16_i<T>(Vector256<T> x, Vector256<T> y, byte spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(v8i(dinx.vblend8x16(v16u(x), v16u(y), spec)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vblend8x16(v16i(x), v16i(y), spec));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(v32i(dinx.vblend8x16(v16u(x), v16u(y), spec)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(v64i(dinx.vblend8x16(v16u(x), v16u(y), spec)));
            else 
                throw unsupported<T>();
        }
    }
}