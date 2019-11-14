//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static T inc<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return inc_u(a);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return inc_i(a);
            else 
                return gfp.inc(a);
        }           

        [MethodImpl(Inline)]
        public static ref T inc<T>(ref T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                    inc_u(ref a);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                    inc_i(ref a);
            else 
                gfp.inc(ref a);
            return ref a;
        }           

        [MethodImpl(Inline)]
        static T inc_i<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.inc(int8(a)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.inc(int16(a)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.inc(int32(a)));
            else
                 return generic<T>(math.inc(int64(a)));
        }

        [MethodImpl(Inline)]
        static T inc_u<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.inc(uint8(a)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.inc(uint16(a)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.inc(uint32(a)));
            else 
                return generic<T>(math.inc(uint64(a)));
        }

        [MethodImpl(Inline)]
        static ref T inc_i<T>(ref T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 math.inc(ref int8(ref a));
            else if(typeof(T) == typeof(short))
                 math.inc(ref int16(ref a));
            else if(typeof(T) == typeof(int))
                 math.inc(ref int32(ref a));
            else
                 math.inc(ref int64(ref a));
            return ref a;
        }

        [MethodImpl(Inline)]
        static ref T inc_u<T>(ref T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 math.inc(ref uint8(ref a));
            else if(typeof(T) == typeof(ushort))
                 math.inc(ref uint16(ref a));
            else if(typeof(T) == typeof(uint))
                 math.inc(ref uint32(ref a));
            else
                 math.inc(ref uint64(ref a));
            return ref a;
        }
    }
}