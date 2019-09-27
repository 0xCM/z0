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
        public static T parse<T>(string src)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(math.parse(src, out sbyte x));
            else if(typematch<T,byte>())
                return generic<T>(math.parse(src, out byte x));
            else if(typematch<T,short>())
                return generic<T>(math.parse(src, out short x));
            else if(typematch<T,ushort>())
                return generic<T>(math.parse(src, out ushort x));
            else if(typematch<T,int>())
                return generic<T>(math.parse(src, out int x));
            else if(typematch<T,uint>())
                return generic<T>(math.parse(src, out uint x));
            else if(typematch<T,long>())
                return generic<T>(math.parse(src, out long x));
            else if(typematch<T,ulong>())
                return generic<T>(math.parse(src, out ulong x));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.parse(src, out float x));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.parse(src, out double x));
            else            
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static ref T parse<T>(string src, out T dst)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                dst = generic<T>(math.parse(src, out sbyte x));
            else if(typematch<T,byte>())
                dst = generic<T>(math.parse(src, out byte x));
            else if(typematch<T,short>())
                dst = generic<T>(math.parse(src, out short x));
            else if(typematch<T,ushort>())
                dst = generic<T>(math.parse(src, out ushort x));
            else if(typematch<T,int>())
                dst = generic<T>(math.parse(src, out int x));
            else if(typematch<T,uint>())
                dst = generic<T>(math.parse(src, out uint x));
            else if(typematch<T,long>())
                dst = generic<T>(math.parse(src, out long x));
            else if(typematch<T,ulong>())
                dst = generic<T>(math.parse(src, out ulong x));
            else if(typeof(T) == typeof(float))
                dst = generic<T>(math.parse(src, out float x));
            else if(typeof(T) == typeof(double))
                dst = generic<T>(math.parse(src, out double x));
            else            
                throw unsupported<T>();
            return ref dst;
        }
    }
}