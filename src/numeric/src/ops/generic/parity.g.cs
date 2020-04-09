//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static As;
            
    public static partial class parity
    {
        /// <summary>
        /// Returns true if a primal integer is odd; false otherwise
        /// </summary>
        /// <param name="a">The value to test</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static bit odd<T>(T a)
            where T : unmanaged
                => odd_u(a);

        /// <summary>
        /// Returns true if a primal integer is even; false otherwise
        /// </summary>
        /// <param name="a">The value to test</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static bit even<T>(T a)
            where T : unmanaged
                => even_u(a);

        [MethodImpl(Inline)]
        static bit odd_u<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Scalar.odd(uint8(a));  
            else if(typeof(T) == typeof(ushort))
                return Scalar.odd(uint16(a));  
            else if(typeof(T) == typeof(uint))
                return Scalar.odd(uint32(a));  
            else if(typeof(T) == typeof(ulong))
                return Scalar.odd(uint64(a));  
            else
                return odd_i(a);
        }           

        [MethodImpl(Inline)]
        static bit odd_i<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Scalar.odd(int8(a));  
            else if(typeof(T) == typeof(short))
                return Scalar.odd(int16(a));  
            else if(typeof(T) == typeof(int))
                return Scalar.odd(int32(a));  
            else if(typeof(T) == typeof(long))
                return Scalar.odd(int64(a)); 
            else
                throw Unsupported.define<T>();
        }           

        [MethodImpl(Inline)]
        static bit even_u<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Scalar.even(uint8(a));  
            else if(typeof(T) == typeof(ushort))
                return Scalar.even(uint16(a));  
            else if(typeof(T) == typeof(uint))
                return Scalar.even(uint32(a));  
            else if(typeof(T) == typeof(ulong))
                return Scalar.even(uint64(a));  
            else
                return even_i(a);
        }           

        [MethodImpl(Inline)]
        static bit even_i<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Scalar.even(int8(a));  
            else if(typeof(T) == typeof(short))
                return Scalar.even(int16(a));  
            else if(typeof(T) == typeof(int))
                return Scalar.even(int32(a));  
            else if(typeof(T) == typeof(long))
                return Scalar.even(int64(a)); 
            else
                throw Unsupported.define<T>();
        }           

    }
}