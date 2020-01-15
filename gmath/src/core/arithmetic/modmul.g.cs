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
        /// Computes z := (a*b) mod m
        /// </summary>
        /// <param name="a">The first factor</param>
        /// <param name="b">The second factor</param>
        /// <param name="m">The modulus</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op,PrimalClosures(PrimalKind.Integers)]
        public static T modmul<T>(T a, T b, T m)
            where T : unmanaged
                => modmul_u(a,b,m);

        [MethodImpl(Inline)]
        static T modmul_u<T>(T a, T b, T m)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.modmul(convert<T,uint>(a), convert<T,uint>(b), convert<T,uint>(m)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.modmul(convert<T,uint>(a), convert<T,uint>(b), convert<T,uint>(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.modmul(uint32(a), uint32(b), uint32(m)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.modmul(uint64(a), uint64(b), uint64(m)));
            else
                return modmul_i(a,b,m);
        }

        [MethodImpl(Inline)]
        static T modmul_i<T>(T a, T b, T m)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.modmul(convert<T,int>(a), convert<T,int>(b), convert<T,int>(m)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.modmul(convert<T,int>(a), convert<T,int>(b), convert<T,int>(m)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.modmul(int32(a), int32(b), int32(m)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.modmul(int64(a), int64(b), int64(m)));
            else
                return gfp.modmul(a,b,m);            
        }
    }
}
