//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
                
    using static Core;
    using static As;

    partial class gmath
    {        
        /// <summary>
        /// Computes the nonnegative distance between two values
        /// </summary>
        /// <param name="a">The first value</param>
        /// <param name="b">The second value</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline), Distance, NumericClosures(NumericKind.Integers)]
        public static ulong dist<T>(T a, T b)
            where T : unmanaged
                => dist_u(a,b);

        [MethodImpl(Inline)]
        static ulong dist_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.dist(convert<T,uint>(a), convert<T,uint>(b));
            else if(typeof(T) == typeof(ushort))
                return math.dist(convert<T,uint>(a), convert<T,uint>(b));
            else if(typeof(T) == typeof(uint))
                return math.dist(uint32(a), uint32(b));
            else if(typeof(T) == typeof(ulong))    
                return math.dist(uint64(a), uint64(b));
            else
                return dist_i(a,b);
        }

        [MethodImpl(Inline)]
        static ulong dist_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return math.dist(convert<T,int>(a), convert<T,int>(b));
            else if(typeof(T) == typeof(short))
                return math.dist(convert<T,int>(a), convert<T,int>(b));
            else if(typeof(T) == typeof(int))
                return math.dist(int32(a), int32(b));
            else if(typeof(T) == typeof(long))    
                return math.dist(int64(a), int64(b));
            else 
                return dist_f(a,b);
        }

        [MethodImpl(Inline)]
        static ulong dist_f<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fmath.dist(float32(a), float32(b));
            else if(typeof(T) == typeof(double))    
                return fmath.dist(float64(a), float64(b));
            else
                throw Unsupported.define<T>();
        }
    }
}