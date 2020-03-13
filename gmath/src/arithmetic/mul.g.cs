//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;    
    using static As;

    partial class gmath
    {        
        /// <summary>
        /// Multiplies two primal values
        /// </summary>
        /// <param name="a">The left value</param>
        /// <param name="b">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Mul, NumericClosures(NumericKind.Integers)]
        public static T mul<T>(T a, T b)
            where T : unmanaged
            => mul_u(a,b);

        [MethodImpl(Inline)]
        static T mul_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<T>(math.mul(convert<T,uint>(a), convert<T,uint>(b)));
            else if(typeof(T) == typeof(ushort))
                return convert<T>(math.mul(convert<T,uint>(a), convert<T,uint>(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.mul(uint32(a), uint32(b)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.mul(uint64(a), uint64(b)));
            else
                return mul_i(a,b);
        }

        [MethodImpl(Inline)]
        static T mul_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return convert<T>(math.mul(convert<T,int>(a), convert<T,int>(b)));
            else if(typeof(T) == typeof(short))
                return convert<T>(math.mul(convert<T,int>(a), convert<T,int>(b)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.mul(int32(a), int32(b)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(math.mul(int64(a), int64(b)));
            else 
                return gfp.mul(a,b);
        }
    }
}
