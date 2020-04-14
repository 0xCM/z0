//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
                
    using static Seed; 
    using static Memories;

    partial class Numeric
    {        
        /// <summary>
        /// Subtracts the right value from the left
        /// </summary>
        /// <param name="a">The left value</param>
        /// <param name="b">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static T sub<T>(T a, T b)
            where T : unmanaged
                => sub_u(a,b);

        [MethodImpl(Inline)]
        static T sub_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<T>(Scalar.sub(convert<T,uint>(a), convert<T,uint>(b)));
            else if(typeof(T) == typeof(ushort))
                return convert<T>(Scalar.sub(convert<T,uint>(a), convert<T,uint>(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Scalar.sub(uint32(a), uint32(b)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Scalar.sub(uint64(a), uint64(b)));
            else 
                return sub_i(a,b);
        }

        [MethodImpl(Inline)]
        static T sub_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return convert<T>(Scalar.sub(convert<T,int>(a), convert<T,int>(b)));
            else if(typeof(T) == typeof(short))
                return convert<T>(Scalar.sub(convert<T,int>(a), convert<T,int>(b)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(Scalar.sub(int32(a), int32(b)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(Scalar.sub(int64(a), int64(b)));
            else 
                return sub_f(a,b);
        }

        static T sub_f<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(Scalar.sub(float32(a), float32(b)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Scalar.sub(float64(a), float64(b)));
            else            
                throw Unsupported.define<T>();
        }
    }
}
