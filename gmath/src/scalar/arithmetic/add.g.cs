//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static AsIn;

    partial class gmath
    {                
        /// <summary>
        /// Adds two primal values
        /// </summary>
        /// <param name="a">The left value</param>
        /// <param name="b">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T add<T>(T a, T b)
            where T : unmanaged
                => unsigned<T>() ? add_u(a,b) 
                 : signedint<T>() ? add_i(a,b) 
                 : gfp.add(a,b);

        [MethodImpl(Inline)]
        static T add_u<T>(T a, T b)
            where T : unmanaged                
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.add(uint8(a), uint8(b)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.add(uint16(a), uint16(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.add(uint32(a), uint32(b)));
            else 
                return generic<T>(math.add(uint64(a),  uint64(b)));
        }

        [MethodImpl(Inline)]
        static T add_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.add(int8(a), int8(b)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.add(int16(a), int16(b)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.add(int32(a), int32(b)));
            else 
                 return generic<T>(math.add(int64(a), int64(b)));
        }

    }
}
