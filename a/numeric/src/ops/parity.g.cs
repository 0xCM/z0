//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Components;
    using static As;
        
    [ApiHost("parity.generic", ApiHostKind.Generic)]
    public static class parity
    {
        /// <summary>
        /// Returns true if a primal integer is odd; false otherwise
        /// </summary>
        /// <param name="a">The value to test</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static bit odd<T>(T a)
            where T : unmanaged
                => odd_u(a);

        /// <summary>
        /// Returns true if a primal integer is even; false otherwise
        /// </summary>
        /// <param name="a">The value to test</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static bit even<T>(T a)
            where T : unmanaged
                => !odd<T>(a);    

        [MethodImpl(Inline)]
        static bit odd_u<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Parity.odd(uint8(a));  
            else if(typeof(T) == typeof(ushort))
                return Parity.odd(uint16(a));  
            else if(typeof(T) == typeof(uint))
                return Parity.odd(uint32(a));  
            else if(typeof(T) == typeof(ulong))
                return Parity.odd(uint64(a));  
            else
                return odd_i(a);
        }           

        [MethodImpl(Inline)]
        static bit odd_i<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Parity.odd(int8(a));  
            else if(typeof(T) == typeof(short))
                return Parity.odd(int16(a));  
            else if(typeof(T) == typeof(int))
                return Parity.odd(int32(a));  
            else if(typeof(T) == typeof(long))
                return Parity.odd(int64(a)); 
            else
                throw Unsupported.define<T>();
        }           
    }
}