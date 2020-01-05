//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        /// <summary>
        /// Computes the distance between two values
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline)]
        public static ulong dist<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(ulong))    
                return math.dist(convert<T,ulong>(a), convert<T,ulong>(b));
            else if(typeof(T) == typeof(float) || typeof(T) == typeof(double))
                return fmath.dist(convert<T,double>(a), convert<T,double>(b));
            else
                return math.dist(convert<T,long>(a), convert<T,long>(b));
        }

    }
}