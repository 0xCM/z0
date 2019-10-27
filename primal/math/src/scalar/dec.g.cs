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
        public static T dec<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return dec_u(a);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return dec_i(a);
            else 
                return gfp.dec(a);
        }           

        [MethodImpl(Inline)]
        public static ref T dec<T>(ref T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return ref dec_u(ref a);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return ref dec_i(ref a);
            else 
                return ref gfp.dec(ref a);
        }           

        [MethodImpl(Inline)]
        static T dec_i<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.dec(int8(a)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.dec(int16(a)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.dec(int32(a)));
            else
                 return generic<T>(math.dec(int64(a)));
        }

        [MethodImpl(Inline)]
        static T dec_u<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.dec(uint8(a)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.dec(uint16(a)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.dec(uint32(a)));
            else 
                return generic<T>(math.dec(uint64(a)));
        }

        [MethodImpl(Inline)]
        static ref T dec_i<T>(ref T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 math.dec(ref int8(ref a));
            else if(typeof(T) == typeof(short))
                 math.dec(ref int16(ref a));
            else if(typeof(T) == typeof(int))
                 math.dec(ref int32(ref a));
            else
                 math.dec(ref int64(ref a));
            return ref a;
        }

        [MethodImpl(Inline)]
        static ref T dec_u<T>(ref T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 math.dec(ref uint8(ref a));
            else if(typeof(T) == typeof(ushort))
                 math.dec(ref uint16(ref a));
            else if(typeof(T) == typeof(uint))
                 math.dec(ref uint32(ref a));
            else
                 math.dec(ref uint64(ref a));
            return ref a;
        }


    }
}