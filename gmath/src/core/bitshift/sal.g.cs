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
        /// Applies an arithmetic left-shift to an integer
        /// </summary>
        /// <param name="src">The value to shift</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline)]
        public static T sal<T>(T src, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return salu(src,offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return sali(src,offset);
            else throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static T sali<T>(T lhs, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.sal(int8(lhs), offset));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.sal(int16(lhs), offset));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.sal(int32(lhs), offset));
            else
                 return generic<T>(math.sal(int64(lhs), offset));
        }

        [MethodImpl(Inline)]
        static T salu<T>(T lhs, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.sal(uint8(lhs), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.sal(uint16(lhs), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.sal(uint32(lhs), offset));
            else 
                return generic<T>(math.sal(uint64(lhs), offset));
        }
    }
}