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
        public static T inc<T>(T src)
            where T : unmanaged
        {
            if(unsignedint<T>())
                return inci(src);
            else if(signedint<T>())
                return incu(src);
            else return gfp.inc(src);
        }           

        [MethodImpl(Inline)]
        public static ref T inc<T>(ref T src)
            where T : unmanaged
        {
            if(unsignedint<T>())
                inci(ref src);
            else if(signedint<T>())
                incu(ref src);
            else gfp.inc(ref src);
            return ref src;
        }           

        [MethodImpl(Inline)]
        static T inci<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.inc(int8(src)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.inc(int16(src)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.inc(int32(src)));
            else
                 return generic<T>(math.inc(int64(src)));
        }

        [MethodImpl(Inline)]
        static T incu<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.inc(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.inc(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.inc(uint32(src)));
            else 
                return generic<T>(math.inc(uint64(src)));
        }

        [MethodImpl(Inline)]
        static ref T inci<T>(ref T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 math.inc(ref int8(ref src));
            else if(typeof(T) == typeof(short))
                 math.inc(ref int16(ref src));
            else if(typeof(T) == typeof(int))
                 math.inc(ref int32(ref src));
            else
                 math.inc(ref int64(ref src));
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T incu<T>(ref T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 math.inc(ref uint8(ref src));
            else if(typeof(T) == typeof(ushort))
                 math.inc(ref uint16(ref src));
            else if(typeof(T) == typeof(uint))
                 math.inc(ref uint32(ref src));
            else
                 math.inc(ref uint64(ref src));
            return ref src;
        }
    }
}