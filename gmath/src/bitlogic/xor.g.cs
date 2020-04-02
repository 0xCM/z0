//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
            
    using static Core;
    
    partial class gmath
    {        
        /// <summary>
        /// Computes the XOR of two primal values
        /// </summary>
        /// <param name="a">The left value</param>
        /// <param name="b">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Xor, NumericClosures(NumericKind.Integers)]
        public static T xor<T>(T a, T b)
            where T : unmanaged
                => xor_u(a,b);

        [MethodImpl(Inline)]
        static T xor_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<T>(math.xor(convert<T,uint>(a), convert<T,uint>(b)));
            else if(typeof(T) == typeof(ushort))
                return convert<T>(math.xor(convert<T,uint>(a), convert<T,uint>(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.xor(uint32(a), uint32(b)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.xor(uint64(a), uint64(b)));
            else
                return xor_i(a,b);
        }

        [MethodImpl(Inline)]
        static T xor_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return convert<T>(math.xor(convert<T,int>(a), convert<T,int>(b)));
            else if(typeof(T) == typeof(short))
                return convert<T>(math.xor(convert<T,int>(a), convert<T,int>(b)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.xor(int32(a), int32(b)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(math.xor(int64(a), int64(b)));
            else
                throw Unsupported.define<T>();
        }
    }
}