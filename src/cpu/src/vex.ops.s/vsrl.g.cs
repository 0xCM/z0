//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    partial struct gcpu
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> vsrl<T>(Vector128<T> x, [Imm] byte count)
            where T : unmanaged
                => vsrl_u(x,count);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> vsrl<T>(Vector256<T> x, [Imm] byte count)
            where T : unmanaged
                => vsrl_u(x,count);

        [MethodImpl(Inline)]
        static Vector128<T> vsrl_u<T>(Vector128<T> x, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(cpu.vsrl(v8u(x), count));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(cpu.vsrl(v16u(x), count));
            else if(typeof(T) == typeof(uint))
                return generic<T>(cpu.vsrl(v32u(x), count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(cpu.vsrl(v64u(x), count));
            else
                return vsrl_i(x,count);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsrl_i<T>(Vector128<T> x, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(cpu.vsrl(v8i(x), count));
            else if(typeof(T) == typeof(short))
                return generic<T>(cpu.vsrl(v16i(x), count));
            else if(typeof(T) == typeof(int))
                return generic<T>(cpu.vsrl(v32i(x), count));
            else if(typeof(T) == typeof(long))
                return generic<T>(cpu.vsrl(v64i(x), count));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsrl_u<T>(Vector256<T> x, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(cpu.vsrl(v8u(x), count));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(cpu.vsrl(v16u(x), count));
            else if(typeof(T) == typeof(uint))
                return generic<T>(cpu.vsrl(v32u(x), count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(cpu.vsrl(v64u(x), count));
            else
                return vsrl_i(x,count);
       }

        [MethodImpl(Inline)]
        static Vector256<T> vsrl_i<T>(Vector256<T> x, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(cpu.vsrl(v8i(x), count));
            else if(typeof(T) == typeof(short))
                return generic<T>(cpu.vsrl(v16i(x), count));
            else if(typeof(T) == typeof(int))
                return generic<T>(cpu.vsrl(v32i(x), count));
            else if(typeof(T) == typeof(long))
                return generic<T>(cpu.vsrl(v64i(x), count));
            else
                throw no<T>();
        }
    }
}