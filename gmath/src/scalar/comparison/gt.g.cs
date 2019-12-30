//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static bit gt<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return gt_u(a,b);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return gt_i(a,b);
            else 
                return gfp.gt(a,b);
        }

        [MethodImpl(Inline)]
        public static T gtz<T>(T a, T b)
            where T : unmanaged
                => gmath.mul(convert<T>((uint)gmath.gt(a,b)),gmath.ones<T>());

        [MethodImpl(Inline)]
        public static bit gteq<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return gteq_u(a,b);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return gteq_i(a,b);
            else
                return gfp.gteq(a,b);
        }

        [MethodImpl(Inline)]
        static bit gt_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return math.gt(int8(a), int8(b));
            else if(typeof(T) == typeof(short))
                 return math.gt(int16(a), int16(b));
            else if(typeof(T) == typeof(int))
                 return math.gt(int32(a), int32(b));
            else
                 return math.gt(int64(a), int64(b));
        }

        [MethodImpl(Inline)]
        static bit gt_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.gt(uint8(a), uint8(b));
            else if(typeof(T) == typeof(ushort))
                return math.gt(uint16(a), uint16(b));
            else if(typeof(T) == typeof(uint))
                return math.gt(uint32(a), uint32(b));
            else 
                return math.gt(uint64(a), uint64(b));
        }

        [MethodImpl(Inline)]
        static bit gteq_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return math.gteq(int8(a), int8(b));
            else if(typeof(T) == typeof(short))
                 return math.gteq(int16(a), int16(b));
            else if(typeof(T) == typeof(int))
                 return math.gteq(int32(a), int32(b));
            else
                 return math.gteq(int64(a), int64(b));
        }

        [MethodImpl(Inline)]
        static bit gteq_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.gteq(uint8(a), uint8(b));
            else if(typeof(T) == typeof(ushort))
                return math.gteq(uint16(a), uint16(b));
            else if(typeof(T) == typeof(uint))
                return math.gteq(uint32(a), uint32(b));
            else 
                return math.gteq(uint64(a), uint64(b));
        }
    }
}