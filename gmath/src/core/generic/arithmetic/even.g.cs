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
    using static AsIn;
    
    partial class gmath
    {
        /// <summary>
        /// Returns true if a primal integer is odd; false otherwise
        /// </summary>
        /// <param name="a">The value to test</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.Integers)]
        public static bit odd<T>(T a)
            where T : unmanaged
                => odd_u(a);

        /// <summary>
        /// Returns true if a primal integer is even; false otherwise
        /// </summary>
        /// <param name="a">The value to test</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.Integers)]
        public static bit even<T>(T a)
            where T : unmanaged
                => !odd<T>(a);    

        [MethodImpl(Inline)]
        static bit odd_u<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return zfunc.odd(uint8(a));  
            else if(typeof(T) == typeof(ushort))
                return zfunc.odd(uint16(a));  
            else if(typeof(T) == typeof(uint))
                return zfunc.odd(uint32(a));  
            else if(typeof(T) == typeof(ulong))
                return zfunc.odd(uint64(a));  
            else
                return odd_i(a);
        }           

        [MethodImpl(Inline)]
        static bit odd_i<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return zfunc.odd(int8(a));  
            else if(typeof(T) == typeof(short))
                return zfunc.odd(int16(a));  
            else if(typeof(T) == typeof(int))
                return zfunc.odd(int32(a));  
            else if(typeof(T) == typeof(long))
                return zfunc.odd(int64(a)); 
            else
                throw unsupported<T>(); 
        }           
    }
}