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
        public static T dec<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return decu(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return deci(src);
            else return gfp.dec(src);
        }           

        [MethodImpl(Inline)]
        public static ref T dec<T>(ref T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                decu(ref src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                deci(ref src);
            else gfp.dec(ref src);
            return ref src;
        }           

        [MethodImpl(Inline)]
        static T deci<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.dec(int8(src)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.dec(int16(src)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.dec(int32(src)));
            else
                 return generic<T>(math.dec(int64(src)));
        }

        [MethodImpl(Inline)]
        static T decu<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.dec(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.dec(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.dec(uint32(src)));
            else 
                return generic<T>(math.dec(uint64(src)));
        }

        [MethodImpl(Inline)]
        static ref T deci<T>(ref T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 math.dec(ref int8(ref src));
            else if(typeof(T) == typeof(short))
                 math.dec(ref int16(ref src));
            else if(typeof(T) == typeof(int))
                 math.dec(ref int32(ref src));
            else
                 math.dec(ref int64(ref src));
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T decu<T>(ref T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 math.dec(ref uint8(ref src));
            else if(typeof(T) == typeof(ushort))
                 math.dec(ref uint16(ref src));
            else if(typeof(T) == typeof(uint))
                 math.dec(ref uint32(ref src));
            else
                 math.dec(ref uint64(ref src));
            return ref src;
        }


    }
}