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
        public static T square<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return square_u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return square_i(src);
            else 
                return gfp.square(src);
        }           

        [MethodImpl(Inline)]
        public static ref T square<T>(ref T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                square_u(ref src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                square_i(ref src);
            else 
                gfp.square(ref src);
            
            return ref src;
        }           

        [MethodImpl(Inline)]
        static T square_i<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.square(int8(src)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.square(int16(src)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.square(int32(src)));
            else
                 return generic<T>(math.square(int64(src)));
        }

        [MethodImpl(Inline)]
        static T square_u<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.square(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.square(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.square(uint32(src)));
            else 
                return generic<T>(math.square(uint64(src)));
        }

        [MethodImpl(Inline)]
        static ref T square_i<T>(ref T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 math.square(ref int8(ref src));
            else if(typeof(T) == typeof(short))
                 math.square(ref int16(ref src));
            else if(typeof(T) == typeof(int))
                 math.square(ref int32(ref src));
            else
                 math.square(ref int64(ref src));
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T square_u<T>(ref T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 math.square(ref uint8(ref src));
            else if(typeof(T) == typeof(ushort))
                 math.square(ref uint16(ref src));
            else if(typeof(T) == typeof(uint))
                 math.square(ref uint32(ref src));
            else
                 math.square(ref uint64(ref src));
            return ref src;
        }
    }
}