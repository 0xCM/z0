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
        [MethodImpl(Inline)]
        public static Vec256<T> vperm2x128<T>(in Vec256<T> lhs, in Vec256<T> rhs, Perm2x128 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vperm2x128_u(lhs,rhs,spec);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vperm2x128_i(lhs,rhs,spec);
            else 
                return vperm2x128_f(lhs,rhs,spec);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vperm2x128<T>(Vector256<T> lhs, Vector256<T> rhs, Perm2x128 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vperm2x128_u(lhs,rhs,spec);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vperm2x128_i(lhs,rhs,spec);
            else 
                return vperm2x128_f(lhs,rhs,spec);
        }

        public static string vperm256_info<T>()
            where T : unmanaged
        {            
            
            var table = sbuild();

            void addRow(string title, string content)
                => table.AppendLine(title.PadRight(20) + content);

            var x0 = gmath.zero<T>();
            var y0 = gmath.one<T>();
            var step = convert<T>(2);
            var x = Vec256Pattern.Increasing<T>(x0,step);
            var y = Vec256Pattern.Increasing(y0,step);        

            addRow("x", x.ToString());
            addRow("y", y.ToString());
            addRow($"x y CA", ginx.vperm2x128(x,y,Perm2x128.CA).Format());
            addRow($"x y DA", ginx.vperm2x128(x,y,Perm2x128.DA).Format());
            addRow($"x y CB", ginx.vperm2x128(x,y,Perm2x128.CB).Format());
            addRow($"x y DB", ginx.vperm2x128(x,y,Perm2x128.DB).Format());

            addRow($"x y AC", ginx.vperm2x128(x,y,Perm2x128.AC).Format());
            addRow($"x y AD", ginx.vperm2x128(x,y,Perm2x128.AD).Format());
            addRow($"x y BC", ginx.vperm2x128(x,y,Perm2x128.BC).Format());
            addRow($"x y BD", ginx.vperm2x128(x,y,Perm2x128.BD).Format());

            return table.ToString();
        }

        [MethodImpl(Inline)]
        static Vec256<T> vperm2x128_u<T>(in Vec256<T> lhs, in Vec256<T> rhs, Perm2x128 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vperm2x128(uint8(lhs), uint8(rhs), spec));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vperm2x128(uint16(lhs), uint16(rhs), spec));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vperm2x128(uint32(lhs), uint32(rhs), spec));
            else
                return generic<T>(dinx.vperm2x128(uint64(lhs), uint64(rhs), spec));
        }

        [MethodImpl(Inline)]
        static Vec256<T> vperm2x128_i<T>(in Vec256<T> lhs, in Vec256<T> rhs, Perm2x128 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vperm2x128(int8(lhs), int8(rhs), spec));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vperm2x128(int16(lhs), int16(rhs), spec));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vperm2x128(int32(lhs), int32(rhs), spec));
            else
                return generic<T>(dinx.vperm2x128(int64(lhs), int64(rhs), spec));
        }

        [MethodImpl(Inline)]
        static Vec256<T> vperm2x128_f<T>(in Vec256<T> lhs, in Vec256<T> rhs, Perm2x128 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dinx.vperm2x128(float32(lhs), float32(rhs),spec));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.vperm2x128(float64(lhs), float64(rhs),spec));
            else
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static Vector256<T> vperm2x128_u<T>(Vector256<T> lhs, Vector256<T> rhs, Perm2x128 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vperm2x128(uint8(lhs), uint8(rhs), spec));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vperm2x128(uint16(lhs), uint16(rhs), spec));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vperm2x128(uint32(lhs), uint32(rhs), spec));
            else
                return generic<T>(dinx.vperm2x128(uint64(lhs), uint64(rhs), spec));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vperm2x128_i<T>(Vector256<T> lhs, Vector256<T> rhs, Perm2x128 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vperm2x128(int8(lhs), int8(rhs), spec));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vperm2x128(int16(lhs), int16(rhs), spec));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vperm2x128(int32(lhs), int32(rhs), spec));
            else
                return generic<T>(dinx.vperm2x128(int64(lhs), int64(rhs), spec));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vperm2x128_f<T>(Vector256<T> lhs, Vector256<T> rhs, Perm2x128 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dinx.vperm2x128(float32(lhs), float32(rhs),spec));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.vperm2x128(float64(lhs), float64(rhs),spec));
            else
                throw unsupported<T>();
        }


    }

}